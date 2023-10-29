using MyLib.Entities;
using MyLib.Repositories;
using MyLib.Usecases;

namespace MyTest
{
    [TestClass]
    public class trouveAnimauxPourUnProprietaire_test
    {
        [TestMethod]
        public void TestMethod()
        {
            MemoryAnimalRepository memoryAnimalRepository = new();
            trouveAnimauxPourUnProprietaire trouveAnimauxPourUnProprietaire = new(memoryAnimalRepository);

            Proprietaire proprietaire = new("Huber", "Marie", "Paris", "75001", "3 Chemin des plantes", "0612345678");

            List<Animal> result = trouveAnimauxPourUnProprietaire.execute(proprietaire);

            Assert.AreEqual(result[0].Nom, "Bob");
        }
    }
}