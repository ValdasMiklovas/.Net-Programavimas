using BaigiamasisDarbas.App;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Repository
{
    public class InvoiceRepository
    {
        private List<Invoice> Invoices { get; set; }
        public InvoiceRepository()
        {
            FileReader reader = new FileReader();
            Invoices = new List<Invoice>();
            var invoices = reader.CsvReader(@"C:\Users\Vartotojas\Desktop\Mokslai\NET Programavimas\Second Try\Kodas\BaigiamasisDarbas\CSV Failai\invoice.csv");
            foreach (var invoice in invoices)
            {
                Invoices.Add(new Invoice(invoice));
            }
        }
        public List<Invoice> GetInvoice()
        {
            return Invoices;
        }
        public Invoice RetrieveInvoiceBy(string name)
        {
            return Invoices.FirstOrDefault(x => x.BuyerName == name);
        }
        public void ClientNotPaidReport()
        {
            foreach (var invoice in Invoices)// voidas mato pirma reik6me
            {
                //Console.WriteLine($"Company:{invoice.BuyerName} In debt:{invoice.TotalPrice} Invoice Not Paid {true}");

                if (invoice.PaidCash == false)
                {
                    Console.WriteLine($"Company:{invoice.BuyerName} In debt:{invoice.TotalPrice} Invoice Not Paid {true}");
                }
            }
        }
        public void SalesMade()
        {
            foreach (var invoice in Invoices)
            {
                Console.WriteLine($"Company: {invoice.BuyerName}, Product Barcode: {invoice.ProductBarcode}, Product: {invoice.ProductName}, Number of Unit: {invoice.Pieces}, Amount: {invoice.TotalPrice}, Paid: {invoice.PaidCash}");
            }
        }
        public void AllInvoicePdf()
        {
            Workbook allInvoice = new Workbook();
            allInvoice.LoadFromFile(@"C:\Users\Vartotojas\Desktop\Mokslai\NET Programavimas\Second Try\Kodas\BaigiamasisDarbas\CSV Failai\invoice.csv", ",", 1, 1);
            allInvoice.ConverterSetting.SheetFitToPage = true;
            Worksheet page = allInvoice.Worksheets[0];
            for (int i = 1; i < page.Columns.Length; i++)
            {
                page.AutoFitColumn(i);
            }
            allInvoice.SaveToFile(@"C:\Users\Vartotojas\Desktop\Mokslai\NET Programavimas\Second Try\Kodas\BaigiamasisDarbas\CSV Failai\Store Invoice.pdf");
        }
    }
}
