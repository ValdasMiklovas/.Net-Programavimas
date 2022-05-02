using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Class
{
    public class Product
    {
        public int Barcode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public Product(string[] product) 
        {
            Barcode=Convert.ToInt32(product[0]);
            ProductName = product[1];
            Quantity = Convert.ToDouble(product[2]);
            Price = Convert.ToDouble(product[3]);
        }
    }
}
