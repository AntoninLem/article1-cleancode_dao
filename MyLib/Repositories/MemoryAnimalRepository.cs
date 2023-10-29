using MyLib.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using MyLib.Repositories.Interfaces;

namespace MyLib.Repositories
{
    public class MemoryAnimalRepository : IAnimalRepository
    {
        List<Animal> animals;

        public MemoryAnimalRepository() {

            Animal a1 = new("1", "111-111-111", "Bob", "M", new DateOnly(2023, 05, 12));
            Animal a2 = new("2", "222-222-222", "Johnson", "F", new DateOnly(2022, 08, 25));
            Animal a3 = new("3", "333-333-333", "Smith", "M", new DateOnly(1990, 03, 15));
            Animal a4 = new("4", "444-444-444", "Davis", "F", new DateOnly(1985, 11, 10));
            Animal a5 = new("5", "555-555-555", "Taylor", "M", new DateOnly(2000, 06, 05));

            Proprietaire p1 = new("Huber", "Marie", "Paris", "75001", "3 Chemin des plantes", "0612345678");
            Proprietaire p2 = new("Dupont", "Jean", "Lyon", "69002", "18 Rue des Fleurs", "0712345678");
            Proprietaire p3 = new("Lefevre", "Sophie", "Marseille", "13008", "25 Avenue du Soleil", "0618765432");
            Proprietaire p4 = new("Garcia", "Pierre", "Toulouse", "31000", "7 Rue de la Liberté", "0654321098");

            Soin s1 = new("Vacination contre la rage", new DateOnly(2023, 05, 12), new DateOnly(2023, 05, 12));
            Soin s2 = new("Médicament contre les puce 1 par jours pendant 1 mois", new DateOnly(2023, 05, 12), new DateOnly(2023, 06, 12));

            a1.assignerProprietaire(p1);
            a2.assignerProprietaire(p2);
            a3.assignerProprietaire(p3);
            a4.assignerProprietaire(p3);
            a5.assignerProprietaire(p2);

            a1.ajoutSoin(s1);
            a2.ajoutSoin(s2);

            this.animals = new() { a1, a2, a3, a4, a5 };

        }

        public List<Animal> getAnimalsParProprietaire(string nom, string prenom, string codepostal)
        {
            return animals.FindAll((x) =>
                (x.Proprietaire.Nom == nom) &&
                (x.Proprietaire.Prenom == prenom) &&
                (x.Proprietaire.CodePostal == codepostal)
            );
        }

        public void addAnimal(Animal animal)
        {
            animals.Add(animal);
        }
    }
}
