using BaigiamasisDarbas.App;
using BaigiamasisDarbas.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Repository
{
    public class ProductRepository
    {
        private List<Product> Products { get; set; }
        public ProductRepository()
        {
            FileReader reader = new FileReader();
            Products = new List<Product>();
            var warehouse = reader.CsvReader(@"C:\Users\Vartotojas\Desktop\Mokslai\NET Programavimas\Second Try\Kodas\.Net-Programavimas\BaigiamasisDarbas\CSV Failai\Warhouse.csv");
            foreach (var product in warehouse)
            {
                Products.Add(new Product(product));
            }
        }
        public List<Product> GetProduct()
        {
            return Products;
        }
        public void ProductWarhouse()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                int num = i + 1;
                Console.WriteLine($"[{num}]- Barcode:{Products[i].Barcode}, ProduktoPavadinimas:{Products[i].ProductName}, Turimas Kiekis: {Products[i].Quantity}, Kaina: {Products[i].Price}Eur");
            }
        }
        public void BuyProduction()
        {
            ProductWarhouse();
            Console.WriteLine("\nWhat product you want to buy?:");
            int input = Convert.ToInt32(Console.ReadLine());
            int index = input - 1;
            Console.WriteLine("\nHow many unit want to buy:");
            int pieces = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDow you will pay with cash? Y/N:");
            string payment = Console.ReadLine();
            bool paid = true;
            if (payment == "y")
            {
                paid = true;
            }
            else if (payment == "n")
            {
                paid = false;
            }
            else
            {
                Console.WriteLine("Bad Selection");
            }
            var pirkiniai = GetProduct();
            foreach (var products in pirkiniai)
            {
                if (index == pirkiniai.IndexOf(products))
                {
                    double totalPrice = products.Price * pieces;
                    string invoiceCsv = @"C:\Users\Vartotojas\Desktop\Mokslai\NET Programavimas\Second Try\Kodas\.Net-Programavimas\BaigiamasisDarbas\CSV Failai\invoice.csv";
                    File.AppendAllText(invoiceCsv, $"{products.Barcode};{products.ProductName};{pieces};{totalPrice};{paid}\n");
                }
            }
        }
    }
}
