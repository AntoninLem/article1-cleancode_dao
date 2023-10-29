namespace MyLib.Entities
{
    public class Soin
    {
        public string Motif { get; set; }
        public DateOnly DateDebut { get; set; }
        public DateOnly DateFin { get; set; }

            
       public Soin(string motif, DateOnly datedebut, DateOnly datefin) {
            this.Motif = motif;
            this.DateDebut = datedebut;
            this.DateFin = datefin;
       }
    }
}
