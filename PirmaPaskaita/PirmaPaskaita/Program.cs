using System;

namespace PirmaPaskaita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////komentaras
            //string name = "";

            //while(name != "stop")
            //{
            //    Console.WriteLine("enter the name");
            //    name = Console.ReadLine();
            //    Console.WriteLine($"Sveiki{name}");
            //}

            //Antra paskaita 2022-03-07
            //1nr užduotis parašyti programą kuri klausia varototoji megstamos spalvos, programa turi visada atsakyti Mano irgi!
            //string Color = "";
            //while (Color != "stop")
            //{
            //    Console.WriteLine("What is your favour color?");
            //    Color = Console.ReadLine();

            //    Console.WriteLine($"{Color} also my favour color ");
            //}
            //Console.Clear();

            //Užduotis Nr2
            //int number1 = 17;
            //int number2 = 23;

            //Console.WriteLine($" suma {number2} + {number1}= {number1+number2}" );

            //Užduotis Nr3

            //double number1 = 24;
            //double number2 = 5;
            //Console.WriteLine($"{number1}/{number2}={number1 / number2}");

            //užduotis Nr4
            //Console.WriteLine(-6 + 3 * 5);
            //Console.WriteLine((13 - 2) * 7);
            //Console.WriteLine((5 + -2) + (20 / 10));

            //užduotis Nr5
            Console.WriteLine("Enter the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            string number2 = Console.ReadLine();// Prieėma betkur simbolį
            int number3;//Tryparse priskiriamas skaičius
            Int32.Parse(number2, out number3);//tekstą keičia į skaičių, jeigu įvesta raidė priskiriama nuliui reikšmė.
            //int number2 = Int32.Parse(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{number1}*{number3}={number1 * number3}");
           //Console.WriteLine($"{number1}/{number3}={number1 / number3}");// nesidalina iš nulio
            Console.WriteLine($"{number1}+{number3}={number1 + number3}");
            Console.WriteLine($"{number1}-{number3}={number1 - number3}");

            ////Užduotis Nr6
            ////Console.WriteLine("Enter the number");
            ////int num = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine($"{num} x 1 = {num * 1}");
            ////Console.WriteLine($"{num} x 2 = {num *2}");
            ////Console.WriteLine($"{num} x 3 = {num * 3}");
            ////Console.WriteLine($"{num} x 4 = {num * 4}");
            ////Console.WriteLine($"{num} x 5 = {num * 5}");
            ////Console.WriteLine($"{num} x 6 = {num * 6}");
            ////Console.WriteLine($"{num} x 7 = {num * 7}");
            ////Console.WriteLine($"{num} x 8 = {num * 8}");
            ////Console.WriteLine($"{num} x 9 = {num * 9}");
            ////Console.WriteLine($"{num} x 10 = {num * 10}");

            // užduotis Nr7

            //Console.WriteLine("Enter 4 numbers");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //int num4 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"average = {(num1+num2+num3+num4)/4}");

            //užduotis nr8
            //Console.WriteLine("Enter 3 numbers");
            //int numA = Convert.ToInt32(Console.ReadLine());
            //int numB = Convert.ToInt32(Console.ReadLine());
            //int numC = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"({numA}+{numB})*{numC}={(numA + numB) * numC}");
            //Console.WriteLine($"{numA}*{numC}+{numB}*{numC}={numA * numC + numB * numC}");

            //užduotis nr9
            //Console.WriteLine("enter the simbol");
            //string symbol = Console.ReadLine();

            //Console.WriteLine($"{symbol}{symbol}{symbol}");
            //Console.WriteLine($"{symbol} {symbol}");
            //Console.WriteLine($"{symbol} {symbol}");
            //Console.WriteLine($"{symbol} {symbol}");
            //Console.WriteLine($"{symbol}{symbol}{symbol}");

            //Užduotis Nr10
            //Console.WriteLine("Enter the Temperature C");
            //int tempC = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($" Kelvis = {tempC}+ 273 = {tempC + 273} K");
            //Console.WriteLine($"FARENHEIT = {tempC}* 18/10 + 32 = {tempC * (18 / 10) + 32} F");







        }
    }
}
