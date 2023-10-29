using MyLib.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using MyLib.Repositories.Interfaces;
using System.Data.SqlClient;

namespace MyLib.Repositories
{
    public class SqlAnimalRepository : IAnimalRepository
    {
        SqlConnection conn;

        public SqlAnimalRepository()
        {
            string sql_url = Environment.GetEnvironmentVariable("SQL_URL");
            string sql_database = Environment.GetEnvironmentVariable("SQL_DATABASE");
            string sql_username = Environment.GetEnvironmentVariable("SQL_USERNAME");
            string sql_password = Environment.GetEnvironmentVariable("SQL_PASSWORD");

            this.conn = new(@$"Server={sql_url};Database={sql_database};User Id={sql_username};Password={sql_password};\r\n");
        }

        public void addAnimal(Animal animal)
        {
            string sql_insert_animal = $@"INSERT INTO Animal (CodeUnqiue, IdICAD, Nom, Genre, DateNaissance) VALUES ('{animal.CodeUnqiue}', '{animal.IdICAD}', '{animal.Nom}', '{animal.Genre}', '{animal.DateNaissance}')";

            this.conn.Open();
            using (SqlCommand command = new(sql_insert_animal, conn))
            {
                command.ExecuteNonQuery();
            }
            this.conn.Close();
        }

        public List<Animal> getAnimalsParProprietaire(string nom, string prenom, string codepostal)
        {
            List<Animal> animals = new();

            this.conn.Open();
            using (SqlCommand command = new("SELECT CodeUnqiue, IdICAD, Nom, Genre, DateNaissance FROM Animal", conn))
            {
                SqlDataReader result = command.ExecuteReader();

                while (result.Read())
                {
                    Animal animal = new(
                            result.GetString(result.GetOrdinal("CodeUnqiue")),
                            result.GetString(result.GetOrdinal("IdICAD")),
                            result.GetString(result.GetOrdinal("Nom")),
                            result.GetString(result.GetOrdinal("Genre")),
                            DateOnly.FromDateTime(
                                result.GetDateTime(result.GetOrdinal("DateNaissance"))
                                )
                        );
                    animals.Add(animal);
                }
            }
            this.conn.Close();

            return animals;
        }

        public Animal getAnimalsParIdICAD(string IdICAD)
        {
            Animal animal = new("", "","","", DateOnly.MinValue);

            this.conn.Open();
            using (SqlCommand command = new($@"SELECT CodeUnqiue, IdICAD, Nom, Genre, DateNaissance FROM Animal WHERE IdICAD = '{IdICAD}'", conn))
            {
                SqlDataReader result = command.ExecuteReader();

                while (result.Read())
                {
                    animal = new(
                            result.GetString(result.GetOrdinal("CodeUnqiue")),
                            result.GetString(result.GetOrdinal("IdICAD")),
                            result.GetString(result.GetOrdinal("Nom")),
                            result.GetString(result.GetOrdinal("Genre")),
                            DateOnly.FromDateTime(
                                result.GetDateTime(result.GetOrdinal("DateNaissance"))
                                )
                        );
                }
            }
            this.conn.Close();

            return animal;
        }
    }
}
