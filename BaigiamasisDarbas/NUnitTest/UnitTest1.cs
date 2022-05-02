using BaigiamasisDarbas.Repository;
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
        public void IsInvoicePaid()//trauksim clienta. Tikrinsim ar kliento vardas atitinka ištraukus per Cliento ID?
        {
            //Arrange(Duomenų Mock'as)- kuriame  vienetą/REIKŠME kuri bus nauduojame testo metodui.
            var invoice = new InvoiceRepository();
            string name = "UAB VedinimasTau";
            bool isPaid = false;

            //Act(Calinam metoda)

            var actualResult = invoice.RetrieveInvoiceBy(name);
                        
            //Assert(Lyginam) - KuriamasKviečiamas testo metodai
            Assert.AreEqual(isPaid, actualResult.PaidCash);
                        
        }
        [Test]
        public void GetClientCreditLimit()
        {
            //arrange
            var clientRepository = new ClientRepository();
            string name = "UAB GaivusOras";
            double credit = 3000;

            //Act
            var actualResult = clientRepository.RetrieveClientId(name);

            //Assert
            Assert.AreEqual(credit, actualResult.Credit);

        }
        [Test]
        public void GetClientNameById()
        {
            //arrange
            var clientRepository = new ClientRepository();
            string name = "UAB VedinimasTau";
            int id = 890512;

            //Act
            var actualResult = clientRepository.RetrieveClientId(name);

            //Assert
            Assert.AreEqual(id, actualResult.ClientId);

        }

    }
}