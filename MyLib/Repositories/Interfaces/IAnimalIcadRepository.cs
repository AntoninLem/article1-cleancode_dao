using MyLib.Entities;

namespace MyLib.Repositories.Interfaces
{
    public interface IAnimalIcadRepository
    {
        Animal getAnimalParIdICAD(string IdICAD);
    }
}
