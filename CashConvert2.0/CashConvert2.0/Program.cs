using System;

namespace CashConvert2._0
{
    internal class Program
    {
        // Valiutų kuras Euro atžilgiu
        public static decimal dollarsBuyRate = 1.1126m;
        public static decimal zlotyBuyRate = 4.6679m;
        public static decimal byRubliBuyRate = 3.0950m;

        static void Main(string[] args)
        {

            for (; ; )
            {
                Console.WriteLine("Welcome to Currency Exchange platform");
                string userIput = MeniuSelection();

                switch (userIput)
                {
                    case "1":
                        decimal moneyInput1 = MoneyAmount();
                        Console.WriteLine($"\nBelongs to you:{ConvertToDollars(moneyInput1)} USD\n");
                        DoYouWanaContinue();

                        break;
                    case "2":
                        decimal moneyInput2 = MoneyAmount();
                        Console.WriteLine($"\nBelongs to you:{ConvertToZlots(moneyInput2)} PLN\n");
                        DoYouWanaContinue();
                        break;
                    case "3":
                        decimal moneyInput3 = MoneyAmount();
                        Console.WriteLine($"\nBelongs to you:{ConvertToBYrubli(moneyInput3)} BYR\n");
                        DoYouWanaContinue();
                        break;
                    default:
                        Console.WriteLine("\nBad selection. Try Again");
                        break;
                }
            }
        }
        public static string MeniuSelection()
        {
            Console.WriteLine("\nSelect currency you want EUR Convert To:\n  [1]- USD [2]- PLN [3]- BYR");
            string input = Console.ReadLine();
            return input;
        }
        public static decimal MoneyAmount()
        {
            decimal amountInput = 0;
            for (; ; )
            {
                Console.WriteLine("\nEnter amount of EUR for convertion:");
                string input = Console.ReadLine();
                bool active = Decimal.TryParse(input, out decimal amountEur);
                if (!active)
                {
                    Console.WriteLine("It is not a number\n");

                }
                else
                {
                    amountInput = amountEur;
                    break;
                }
            }
            return amountInput;
        }
        public static decimal ConvertToDollars(decimal x)
        {
            decimal sumDollars = x * dollarsBuyRate;
            return sumDollars;
        }
        public static decimal ConvertToZlots(decimal y)
        {
            decimal sumZlots = y * zlotyBuyRate;
            return sumZlots;
        }
        public static decimal ConvertToBYrubli(decimal z)
        {
            decimal sumBYrubli = z * byRubliBuyRate;
            return sumBYrubli;
        }
        public static void DoYouWanaContinue()
        {
            for (; ; )
            {
                Console.WriteLine(" Do you want to change more Currency? Y/N\n");
                string decision = Console.ReadLine();
                if (decision.ToLower() == "y")
                {
                    break;
                }
                else if (decision.ToLower() == "n")
                {
                    Console.WriteLine("Have a nice day\n");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Selection does not exist\n");
                }
            }
        }
    }
}
