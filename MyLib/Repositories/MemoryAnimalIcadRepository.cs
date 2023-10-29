using MyLib.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using MyLib.Repositories.Interfaces;

namespace MyLib.Repositories
{
    public class MemoryAnimalIcadRepository : IAnimalIcadRepository
    {
        List<Animal> animals;

        public MemoryAnimalIcadRepository()
        {
            Animal a0 = new("", "000-000-000", "", "", DateOnly.MinValue);
            Animal a1 = new("", "111-111-111", "", "", DateOnly.MinValue);
            Animal a2 = new("", "222-222-222", "", "", DateOnly.MinValue);
            Animal a3 = new("", "333-333-333", "", "", DateOnly.MinValue);
            Animal a4 = new("", "444-444-444", "", "", DateOnly.MinValue);

            Proprietaire p1 = new("", "", "", "", "", "0612345678");
            Proprietaire p2 = new("", "", "", "", "", "0712345678");
            Proprietaire p3 = new("", "", "", "", "", "0618765432");
            Proprietaire p4 = new("", "", "", "", "", "0654321098");

            a0.assignerProprietaire(p4);
            a1.assignerProprietaire(p1);
            a2.assignerProprietaire(p2);
            a3.assignerProprietaire(p3);
            a4.assignerProprietaire(p3);


            this.animals = new() { a0, a1, a2, a3, a4 };
        }

        public Animal getAnimalParIdICAD(string IdICAD)
        {
            return this.animals.First((x) =>
                x.IdICAD == IdICAD
            );
        }
    }
}
