using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Class
{
    public class Client
    {
        public string ClientName { get; set; }
        public int ClientId { get; set; }
        public double Credit { get; set; }

        public Client(string[] client)
        {
            ClientName = client[0];
            ClientId = Convert.ToInt32(client[1]);
            Credit = Convert.ToDouble(client[2]);

        }
        public Client(string name, int id, double credit)
        {
            ClientName = name;
            ClientId = id;
            Credit = credit;
        }
    }
}
