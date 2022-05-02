using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Repository
{
    public class Invoice
    {
        public string BuyerName { get; set; }
        public double ProductBarcode { get; set; }
        public string ProductName { get; set; }
        public int Pieces { get; set; }
        public double TotalPrice { get; set; }
        public bool PaidCash { get; set; }

        public Invoice(string[] item)
        {
            BuyerName = item[0];
            ProductBarcode = Convert.ToInt32(item[1]);
            ProductName = item[2];
            Pieces = Convert.ToInt32(item[3]);
            TotalPrice = Convert.ToDouble(item[4]);
            PaidCash = Convert.ToBoolean(item[5]);
        }
    }
}
