namespace MyLib.Entities
{
    public class Animal
    {
        public string CodeUnqiue { get; set; }
        public string IdICAD { get; set; }
        public string Nom { get; set; }
        public string Genre { get; set; }
        public DateOnly DateNaissance { get; set; }
        public List<Soin> Soins { get; set; }
        public Proprietaire Proprietaire { get; set; }

        public Animal(string codeunique, string idicad, string nom, string genre, DateOnly datenaissance)
        {
            this.CodeUnqiue = codeunique;
            this.IdICAD = idicad;
            this.Nom = nom;
            this.Genre = genre;
            this.DateNaissance = datenaissance;
            this.Soins = new();
        }

        public void ajoutSoin(Soin soin)
        {
            this.Soins.Add(soin);
        }

        public void assignerProprietaire(Proprietaire proprietaire)
        {
            this.Proprietaire = proprietaire;
        }
    }
}