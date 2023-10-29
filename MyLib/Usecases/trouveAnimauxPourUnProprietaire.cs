using MyLib.Entities;
using MyLib.Repositories.Interfaces;

namespace MyLib.Usecases
{
    public class trouveAnimauxPourUnProprietaire
    {
        IAnimalRepository AnimalRepository;

        public trouveAnimauxPourUnProprietaire(IAnimalRepository animalRepository)
        {
            this.AnimalRepository = animalRepository;
        }

        public List<Animal> execute(Proprietaire proprietaire)
        {
            return this.AnimalRepository.getAnimalsParProprietaire(proprietaire.Nom, proprietaire.Prenom, proprietaire.CodePostal);
        }
    }
}
