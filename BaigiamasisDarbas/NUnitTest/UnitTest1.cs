using NUnit.Framework;

namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           //Arrange(Duomenų Mock'as)- kuriame  vienetą/REIKŠME kuri bus nauduojame testo metodui.

            //TestavimoVienetas=reikšmė;
            //TurimoRezultatoVienetas=Reikšmė

            //Act(Calinam metoda)

            //Kviečiamas metodas.
            //var pavadinimas= ClassPavadinimas.MetodoPavadinimas(Sukurto vienetas)

            //Assert(Lyginam)-KuriamasKviečiamas testo metodai
            //pvz: Asser.AreEqual(sukurtas vienetas, turimas gauti vienetas)
            
            
            Assert.Pass();
        }
    }
}