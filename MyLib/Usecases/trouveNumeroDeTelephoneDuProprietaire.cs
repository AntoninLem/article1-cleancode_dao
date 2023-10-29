using MyLib.Entities;
using MyLib.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Usecases
{
    public class trouveNumeroDeTelephoneDuProprietaire
    {
        IAnimalIcadRepository AnimalIcadRepository;

        public trouveNumeroDeTelephoneDuProprietaire(IAnimalIcadRepository animalIcadRepository)
        {
            this.AnimalIcadRepository = animalIcadRepository;
        }

        public Animal excute(Animal animal)
        {
            Animal animal_icad = this.AnimalIcadRepository.getAnimalParIdICAD(animal.IdICAD);

            return animal_icad;
        }
    }
}
