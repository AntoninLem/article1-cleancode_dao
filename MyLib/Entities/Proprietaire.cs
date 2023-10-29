using System.Globalization;

namespace MyLib.Entities
{
    public class Proprietaire
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Adresse { get; set; }
        public string NumTelephone { get; set; }
        
        public Proprietaire(string nom, string prenom, string ville, string codepostal, string adresse, string numtelephone)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Ville = ville;
            this.CodePostal = codepostal;
            this.Adresse = adresse;
            this.NumTelephone = numtelephone;
        }
    }
}
