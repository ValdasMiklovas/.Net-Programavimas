using System;
using System.Collections.Generic;

namespace CashConvert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool app = true;
            while (app)
            {
                int firstSelection = MeniuFirstChoise();
                CurrencyVault(firstSelection);


                //int secondSelection = MeniuSecondChoise();
                //ExchangeVault(secondSelection);


            }
        }
        public static int MeniuFirstChoise()//pasirenkame norima valiutą kuri bus konvertojama į kitą
        {
            bool check = true;
            int selection=0;
            do
            {
                Console.WriteLine("Which currency want Convert From:\n [0]- EUR [1]- USD [2]- PLN [3]- BYR [4]- Exit");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input <= 0)
                {
                    selection = input;
                    //check = false;
                    break;
                }
                if (input == 4)
                {
                    Console.WriteLine("Bye, Have a nice day =)");
                    //check = false;
                    
                    break;
                }
                else
                {
                    Console.WriteLine("bad selection");
                }
                  
            }
            while (check);
            return selection;
        }
        public static int MeniuSecondChoise()//paasirenkama valiutat į kurią bus konvertuojama.
        {
            Console.WriteLine("Which currency want Convert to:\n [0]- Eur [1]- USD [2]- PLN [3]- BYR [4]- Exit");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input <= 3)
            {

            }
            return input;

        }
        public static int CurrencyVault(int x)// 2ia reikia susikurti string lista su galimo valiutom, jų indikacija atitiks pasirinkimo eile
        {

            List<string> currency = new List<string> { "EUR", "USD", "PLN", "BYR" };
            for (int i = 0; i < currency.Count; i++)
            {
                if (i == x)
                {
                    Console.WriteLine($"Your selected currency:{currency[i]}");
                }
                else
                {

                }
            }
            return x;
        }
        public static int ExchangeVault(int y)//čia susikuriame valiutų lista į kurias galime iškeisti, pasirinkimo langelis būtu vietos indexsas
        {
            List<string> exchangeCurrency = new List<string> { "EUR", "USD", "PLN", "BYR" };
            for (int i = 0; i < exchangeCurrency.Count; i++)
            {
                if (i == y)
                {
                    Console.WriteLine($"Your selected currency:{exchangeCurrency[i]}");
                }
                else
                {
                    Console.WriteLine("Selected currency does not exist");
                }

            }
            return y;

        }
        public static void TodayCurrencyExchangeRate()// šios dienos kursas.
        {

        }

        public static void CurrencySelectionConvert()// inputo priskirimas.Veiksmas
        {

        }





    }






}
