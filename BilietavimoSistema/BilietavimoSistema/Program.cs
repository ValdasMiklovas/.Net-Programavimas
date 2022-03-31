using System;

namespace BilietavimoSistema
{

    internal class Program
    {
        public static int totalCreatedTicket10 = 0;
        public static int totalSoldTicket10 = 0;
        public static int totalCreatedTicket20 = 0;
        public static int totalSoldTicket20 = 0;
        public static int totalCreatedTicket30 = 0;
        public static int totalSoldTicket30 = 0;

        static void Main(string[] args)
        {
            bool App = true;

            while (App)
            {
                string meniu = Meniu();
                switch (meniu)
                {
                    case "1":
                        BuyTicket();
                        break;
                    case "2":
                        CreateTicket();
                        break;
                    case "3":
                        SalesReport();
                        break;
                    case "4":
                        Console.WriteLine("Bye, till next time =)");
                        App = false;
                        break;
                    default:
                        Console.WriteLine("your Choise does not exists. Try again.");
                        break;
                }
            }

        }
        public static int TicketBalance10()
        {
            int ticketBalance = totalCreatedTicket10 - totalSoldTicket10;
            return ticketBalance;
        }
        public static int TicketBalance20()
        {
            int ticketBalance = totalCreatedTicket20 - totalSoldTicket20;
            return ticketBalance;
        }
        public static int TicketBalance30()
        {
            int ticketBalance = totalCreatedTicket30 - totalSoldTicket30;
            return ticketBalance;
        }
        public static void SalesReport()
        {
            Console.WriteLine($"Available [1] tickets for Sale:{totalCreatedTicket10}");
            Console.WriteLine($"Tickets [1] sold:{totalSoldTicket10}");
            Console.WriteLine($"Tickets [1] balance:{TicketBalance10()}");

            Console.WriteLine($"Available [2] tickets for Sale:{totalCreatedTicket20}");
            Console.WriteLine($"Tickets [2] sold:{totalSoldTicket20}");
            Console.WriteLine($"Tickets [2] balance:{TicketBalance20()}");

            Console.WriteLine($"Available [3] tickets for Sale:{totalCreatedTicket30}");
            Console.WriteLine($"Tickets [3] sold:{totalSoldTicket30}");
            Console.WriteLine($"Tickets [3] balance:{TicketBalance30()}");

        }
        public static void CreateTicket()
        {
            bool repeat = true;
            do
            {
                string createMeniu = CreateMeniu();
                switch (createMeniu)
                {
                    case "1":
                        CreateTicket10();
                        break;
                    case "2":
                        CreateTicket20();
                        break;
                    case "3":
                        CreateTicket30();
                        break;
                    case "4":
                        Console.Clear();
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Your Selection Does not exist. Try Again");
                        break;

                }

            }
            while (repeat);

        }
        public static string Meniu()
        {
            Console.WriteLine("\nWelcome to Ticket Booking system \n Select action in Menu: ");
            Console.WriteLine("[1] - Buy Travel Ticket [2] - Create Travel Tickets [3] - Sales Report [4]-Exit");
            string userMeniuSelection = Console.ReadLine();
            return userMeniuSelection;
        }
        public static string BuyMeniu()
        {
            Console.WriteLine("Select your destination:\n [1] - Ticket to Palanga 10€ [2] - Ticket to Tenerifę 20€ [3] - Ticket to Hawai 30€ [4]-Exit");
            string userTicketSelect = Console.ReadLine();
            return userTicketSelect;

        }
        public static string CreateMeniu()
        {
            Console.WriteLine("Select ticket \n [1] - Ticket to Palanga 10€ [2] - Ticket to Tenerifę 20€ [3] - Ticket to Hawai 30€ [4]-Exit");
            string userSelection = Console.ReadLine();
            return userSelection;
        }
        public static void BuyTicket()
        {
            bool repeat = true;
            do
            {
                string buyMeniu = BuyMeniu();
                switch (buyMeniu)
                {
                    case "1":
                        BuyTicket10();
                        repeat = false;
                        break;
                    case "2":
                        BuyTicket20();
                        repeat = false;
                        break;
                    case "3":
                        BuyTicket30();
                        repeat = false;
                        break;
                    case "4":
                        Console.Clear();
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Your Selection does not exists. Try Again");
                        break;
                }

            }
            while (repeat);

        }
        public static void BuyTicket10()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("What amount of ticket, want to buy:");
                string ticket10Amount = Console.ReadLine();
                bool isNumber10 = Int32.TryParse(ticket10Amount, out int amount10);
                if (isNumber10 == true)
                {
                    if (TicketBalance10() >= amount10)
                    {
                        Console.WriteLine($"You Bought:{amount10} tickets");
                        totalSoldTicket10 = totalSoldTicket10 + amount10;
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("The quantity you want to buy is not possible");

                    }
                }
                else
                {
                    Console.WriteLine("Entered number is not a number. Try again");

                }

            }
            while (repeat);


        }
        public static void BuyTicket20()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("What amount of ticket, want to buy:");
                string ticket20Amount = Console.ReadLine();
                bool isNumber20 = Int32.TryParse(ticket20Amount, out int amount20);
                if (isNumber20 == true)
                {
                    if (TicketBalance20() >= amount20)
                    {
                        Console.WriteLine($"You Bought:{amount20} tickets");
                        totalSoldTicket10 = totalSoldTicket20 + amount20;
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Entered number is not a number. Try again");
                    }

                }
                else
                {
                    Console.WriteLine("Entered number is not a number. Try again");
                }
            }
            while (repeat);
        }
        public static void BuyTicket30()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("What amount of ticket, want to buy:");
                string ticket30Amount = Console.ReadLine();
                bool isNumber30 = Int32.TryParse(ticket30Amount, out int amount30);
                if (isNumber30 == true)
                {
                    if (TicketBalance30() >= amount30)
                    {
                        Console.WriteLine($"You Bought:{amount30} tickets");
                        totalSoldTicket30 = totalSoldTicket30 + amount30;
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Entered number is not a number. Try again");

                    }
                }
                else
                {
                    Console.WriteLine("Entered number is not a number. Try again");
                }
            }
            while (repeat);
        }
        public static void CreateTicket10()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("How many ticket add:");
                string ticket10Add = Console.ReadLine();
                bool isNumber10 = Int32.TryParse(ticket10Add, out int amount10Add);
                if (isNumber10 == true)
                {
                    totalCreatedTicket10 = totalCreatedTicket10 + amount10Add;
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Entered number is not a number. Try again");
                }
            }
            while (repeat);
        }
        public static void CreateTicket20()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("how many ticket add:");
                string ticket20Add = Console.ReadLine();
                bool isNumber20 = Int32.TryParse(ticket20Add, out int amount20Add);
                if (isNumber20 == true)
                {
                    totalCreatedTicket20 = totalCreatedTicket20 + amount20Add;
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Entered number is not a number. Try again");
                }
            }
            while (repeat);
        }
        public static void CreateTicket30()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("How many ticket add:");
                string ticket30Add = Console.ReadLine();
                bool isNumber30 = Int32.TryParse(ticket30Add, out int amount30Add);
                if (isNumber30 == true)
                {
                    totalCreatedTicket30 = totalCreatedTicket30 + amount30Add;
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Entered number is not a number. Try again");
                }
            } while (repeat);
        }
    }
}
