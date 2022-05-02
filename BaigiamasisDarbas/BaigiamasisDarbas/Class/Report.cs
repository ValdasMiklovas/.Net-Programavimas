using BaigiamasisDarbas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Class
{
    public class Report
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Balance { get; set; }
        public bool Paid { get; set; }
        public double Amount { get; set; }

        public Report(string name, int id, double balance)
        {
            Name = name;
            Id = id;
            Balance = balance;
        }
        public Report(string name, int id, double amount, bool paid)
        {
            Name=name;
            Id = id;
            Amount = amount;
            Paid = paid;
        }
    }
}
