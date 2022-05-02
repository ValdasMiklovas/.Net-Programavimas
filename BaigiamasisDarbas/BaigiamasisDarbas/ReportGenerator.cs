using BaigiamasisDarbas.Class;
using BaigiamasisDarbas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas
{
    public class ReportGenerator
    {
        private ClientRepository ClientRepo { get; set; }
        private InvoiceRepository InvoiceRepo { get; set; }

        public ReportGenerator(ClientRepository clientRepository, InvoiceRepository invoiceRepository)
        {
            ClientRepo = clientRepository;
            InvoiceRepo = invoiceRepository;
        }

        public List<Report> ShopClientReport()
        {
            var clientReport = new List<Report>();
            var clients = ClientRepo.GetClient();
            foreach (var client in clients)
            {
                var buyer = InvoiceRepo.RetrieveInvoiceBy(client.ClientName);
                if (buyer != null)
                {
                    var creditBalance = client.Credit - buyer.TotalPrice;
                    clientReport.Add(new Report(client.ClientName, client.ClientId, creditBalance));
                    Console.WriteLine($"Company:{client.ClientName} Acount:{client.ClientId} Credit balance: {creditBalance}");
                }
                else
                {
                    var creditBalance = client.Credit;
                    clientReport.Add(new Report(client.ClientName, client.ClientId, creditBalance));
                    Console.WriteLine($"Company:{client.ClientName} Acount:{client.ClientId} Credit balance: {creditBalance}");
                }
            }
            return clientReport;
        }
        public List<Report> InvoiceNotPaid()
        {
            var clientsInvoice = new List<Report>();
            var invoice = InvoiceRepo.GetInvoice();
            foreach (var bill in invoice)
            {
                var buyer = ClientRepo.RetrieveClientId(bill.BuyerName);
                if (buyer != null)
                {
                    if (bill.PaidCash == false)
                    {
                        clientsInvoice.Add(new Report(buyer.ClientName, buyer.ClientId, bill.TotalPrice, bill.PaidCash));
                        Console.WriteLine($"Company:{buyer.ClientName} Acount:{buyer.ClientId} Amount: {bill.TotalPrice} Paid: {bill.PaidCash}");
                    }
                }
            }
            return clientsInvoice;
        }
    }
}
