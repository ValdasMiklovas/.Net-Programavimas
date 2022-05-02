using BaigiamasisDarbas.App;
using BaigiamasisDarbas.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Spire.Xls;



namespace BaigiamasisDarbas.Repository
{
    public class ClientRepository
    {
        private List<Client> Clients { get; set; }
        public ClientRepository()
        {
            FileReader reader = new FileReader();
            Clients = new List<Client>();
            var clientList = reader.CsvReader(@"C:\Users\Vartotojas\Desktop\Mokslai\NET Programavimas\Second Try\Kodas\.Net - Programavimas\BaigiamasisDarbas\CSV Failai\Client.csv");

            foreach (var client in clientList)
            {
                Clients.Add(new Client(client));
            }
        
        }
        public List<Client> GetClient()
        {
            return Clients;
        }
        public Client RetrieveClientId(string name)
        {
            return Clients.FirstOrDefault(x => x.ClientName == name);
        }
        public void AddNewClient()
        {
            var naujasKlientas = new List<Client>();
            Console.WriteLine("Enter the Company Name:");
            string newClientName = Console.ReadLine();
            Console.WriteLine("\nWhat size Credit need:");
            double newClientCredit = Convert.ToDouble(Console.ReadLine());
            int clientId = IdGenerator();
            naujasKlientas.Add(new Client(newClientName, clientId, newClientCredit));
            string csvFile = @"C:\Users\Vartotojas\Desktop\Mokslai\NET Programavimas\Second Try\Kodas\.Net - Programavimas\BaigiamasisDarbas\CSV Failai\Client.csv";
            string invoiceCsv = @"C:\Users\Vartotojas\Desktop\Mokslai\NET Programavimas\Second Try\Kodas\.Net - Programavimas\BaigiamasisDarbas\CSV Failai\invoice.csv";
            foreach (var add in naujasKlientas)
            {
                File.AppendAllText(csvFile, $"{add.ClientName};{add.ClientId};{add.Credit}\n");
                File.AppendAllText(invoiceCsv, $"{add.ClientName};");
            }
        }
        public int IdGenerator()
        {
            int min = 100000;
            int max = 999999;
            Random id = new Random();
            return id.Next(min, max);
        }
        public void LogIn()
        {
            bool work = true;
            do
            {
                Console.WriteLine("Enter you Client ID for user Log in:");
                string userLog = Console.ReadLine();
                bool IsNumbers = Int32.TryParse(userLog, out int logIn);
                if (IsNumbers == true)
                {
                    foreach (var item in Clients)
                    {
                        if (logIn == item.ClientId)
                        {
                            Console.Clear();
                            Console.WriteLine($"\tWelcome: {item.ClientName}");
                            string invoice = @"C:\Users\Vartotojas\Desktop\Mokslai\NET Programavimas\Second Try\Kodas\.Net - Programavimas\BaigiamasisDarbas\CSV Failai\invoice.csv";
                            File.AppendAllText(invoice, $"{item.ClientName};");
                            work = false;
                        }
                    }
                }
                else
                {

                    Console.WriteLine("User does not found");
                }

            } while (work);
        }
        public void ClientReportPdf()
        {
            Workbook clientReport = new Workbook();
            clientReport.LoadFromFile(@"C:\Users\Vartotojas\Desktop\Mokslai\NET Programavimas\Second Try\Kodas\.Net - Programavimas\BaigiamasisDarbas\CSV Failai\Client.csv", ",", 1, 1);
            clientReport.ConverterSetting.SheetFitToPage = true;
            Worksheet page = clientReport.Worksheets[0];
            for (int i = 1; i < page.Columns.Length; i++)
            {
                page.AutoFitColumn(i);
            }
            clientReport.SaveToFile(@"C:\Users\Vartotojas\Desktop\Mokslai\NET Programavimas\Second Try\Kodas\.Net - Programavimas\BaigiamasisDarbas\CSV Failai\Store Clients.pdf");
        }
    }
}

