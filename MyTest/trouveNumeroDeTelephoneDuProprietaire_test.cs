using MyLib.Entities;
using MyLib.Repositories;
using MyLib.Usecases;

namespace MyTest
{
    [TestClass]
    public class trouveNumeroDeTelephoneDuProprietaire_test
    {
        [TestMethod]
        public void TestMethod()
        {
            Animal a_test = new Animal("", "000-000-000", "", "", DateOnly.MinValue);

            MemoryAnimalIcadRepository repository = new();
            trouveNumeroDeTelephoneDuProprietaire fonction = new(repository);

            a_test = fonction.excute(a_test);

            Assert.AreEqual(a_test.Proprietaire.NumTelephone, "0654321098");
        }
    }
}