using BaigiamasisDarbas.Class;
using BaigiamasisDarbas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.App
{

    public class Shop
    {
        public void SayHello()
        {
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("\n\t\t\t\t SVEIKI ATVYKE\n\t\t\t Į KATILŲ IR REKUPERATORIŲ CENTRĄ\n");
            Console.WriteLine("***********************************************************************************");
        }
        public void FrontMeniu()
        {
            Console.WriteLine("[1] - Log In to your Acount");
            Console.WriteLine("[2] - New Custumer");
            Console.WriteLine("[3] - Administration");
            Console.WriteLine("[4] - Exit");
        }
        public void ShopApp()
        {
            bool access = true;
            do
            {
                SayHello();
                FrontMeniu();
                Console.WriteLine("CHOOSE THE OPTION OF INTEREST:");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        SayHello();
                        var log = new ClientRepository();
                        log.LogIn();
                        Store();
                        break;
                    case "2":
                        Console.Clear();
                        SayHello();
                        var newClient = new ClientRepository();
                        newClient.AddNewClient();
                        Console.Clear();
                        Store();
                        break;
                    case "3":
                        Console.Clear();
                        SayHello();
                        Reports();
                        break;
                    case "4":
                        var printClient = new ClientRepository();
                        printClient.ClientReportPdf();
                        var printInvoice = new InvoiceRepository();
                        printInvoice.AllInvoicePdf();
                        access = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("SELECTION DOES NOT EXITS");
                        break;
                }
            } while (access);

        }
        public void Store()
        {
            bool operating = true;
            do
            {
                SayHello();
                var medziagos = new ProductRepository();
                medziagos.BuyProduction();
                Console.Clear();
                operating = false;
            }
            while (operating);
        }
        public void Reports()
        {
            bool work = true;
            do
            {
                Console.WriteLine("[1] - Shop Clients with credit limit\n[2] - Companys and Invoicces which are not paid\n[3] - All Sales report \n[4] - Back To main Meniu");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        var report = new ReportGenerator(new ClientRepository(), new InvoiceRepository());
                        Console.Clear();
                        Console.WriteLine("REPORT:");
                        report.ShopClientReport();

                        break;
                    case "2":
                        var reportTwo = new ReportGenerator(new ClientRepository(), new InvoiceRepository());
                        Console.Clear();
                        Console.WriteLine("REPORT:");
                        reportTwo.InvoiceNotPaid();

                        break;
                    case "3":
                        var reportThree = new InvoiceRepository();
                        Console.Clear();
                        Console.WriteLine("REPORT:");
                        reportThree.SalesMade();
                        break;
                    case "4":
                        Console.Clear();
                        work = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Selection NOT EXIST");
                        break;
                }
            } while (work);
        }

    }
}
