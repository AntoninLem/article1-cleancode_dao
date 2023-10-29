using MyLib.Entities;

namespace MyLib.Repositories.Interfaces
{
    public interface IAnimalRepository
    {
        List<Animal> getAnimalsParProprietaire(string nom, string prenom, string codepostal);
        void addAnimal(Animal animal);
    }
}
