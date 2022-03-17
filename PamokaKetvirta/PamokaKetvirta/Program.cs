using System;

namespace PamokaKetvirta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Paskaita CIKLAI
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Sukasi ciklas Siuo metu yra:{i}");
            //}

            //for (int i = 0; i < 10; i += 2)
            //{
            //    Console.WriteLine($"Sukasi ciklas Siuo metu yra:{i}");
            //}

            //Iteracijos per simbolių diapozoną
            //for (char i = 'a'; i < 'z'; i++)
            //{
            //    Console.WriteLine(i);
            //}
            ////Iteracija per stringą

            //string name = "Petriukas";

            //int length = name.Length;

            //for (int i = 0; i < name.Length; i++)
            //{
            //    char current = name[i];
            //    Console.WriteLine(current);
            //}


            ////Pabėgimas iš ciklo
            //string name = "Petriukas";

            //int length = name.Length;

            //for (int i = 0; i < name.Length; i++)
            //{
            //    char current = name[i];
            //    if (current == 'u')
            //    {
            //        break;
            //    }
            //    Console.WriteLine(current);
            //}

            //or Ciklo pratęsimas
            //string name = "Petriukas";

            //int length = name.Length;


            //for (int i = 0; i < name.Length; i++)
            //{
            //    char current = name[i];
            //    if (current == 'u')
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(current);
            //}

            //Savarankiškas darbas/Namų darbai 
            //Užduotis Nr.1 Paprašyti vartotojo įvesti betkokį skaičių. Išvesti skaičių sumą nuo 1 iki Įvesto skaičiaus imtinai).
            //while (true)
            //{
            //    Console.WriteLine("Enter the number");
            //    string input = Console.ReadLine();
            //    bool isNumber = Int32.TryParse(input, out int number);
            //    int sum = 0;
            //    if (isNumber == true)
            //    {
            //        for (int i = 1; i < number; i++)
            //        {
            //            sum += i;
            //        }
            //        Console.WriteLine($"Total number sum:{sum}");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong input, try again");
            //    }


            //}
            //Užduotis Nr2 Paprašyti vartotojo įveti betkokį skaičių. Išvesti visus lyginius skaičius.

            //while (true)
            //{
            //    Console.WriteLine("Enter the number");
            //    string input = Console.ReadLine();
            //    bool isNumber = Int32.TryParse(input, out int number);
            //    if (isNumber == true)
            //    {
            //        for (int i = 1; i <= number; i++)
            //        {
            //            if (i % 2 == 0)
            //            {
            //                Console.Write($" {i}, ");

            //            }
            //            else
            //            {
            //                continue;
            //            }
            //        }
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong input, Try again");
            //    }

            //}

            // Užduotis nr3. Vartotojas įveda sakinį, programa išveda visus simbolius atvirkštine tvarka.

            //Console.WriteLine("Enter the sentence:");
            //string sentence = Console.ReadLine();


            //for (int i = sentence.Length - 1 ; i >=0; i--) //Nesuprantu kaip aprašoma kad imtu simbolius nuo galo
            //{
            //    Console.Write(sentence[i]); 
            //}

            //Užduotis Nr.4. Parašyti kalkuliattorių. Vartotojas įveda 2 skaičius ir operacijos simbolį. Programa išveda rezultatą ir klausia ar testi toliau (Taip ar ne) Nauduoti begalinį ciklą ir break.

            

            //2 varaintas.
            bool sprendimas = true;
            do
            {

                int firstNumber;
                int secondNumber;

                while (true) // pirmo skaičio ciklas
                {
                    Console.WriteLine("Enter the first number");
                    string input = Console.ReadLine();
                    bool isThisNumber = Int32.TryParse(input, out int number1);
                    if (isThisNumber == true)
                    {
                        firstNumber = number1;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Bad first input, try again");
                    }

                }

                while (true)
                {
                    Console.WriteLine("Enter the second number");
                    string input2 = Console.ReadLine();
                    bool isThisNumber2 = Int32.TryParse(input2, out int number2);
                    if (isThisNumber2 == true)
                    {
                        secondNumber = number2;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Bad Second input try again");

                    }

                }

                while (true)
                {
                    Console.WriteLine("What operation want to perform? (-,+,/,*)");
                    string input3 = Console.ReadLine();
                    char simbol = char.Parse(input3); //lužta programa jeigu įveda daugiau simbolių nei viena.
                    //switch (simbol)
                    //{
                    //    case '-':
                    //        Console.WriteLine($"{firstNumber}-{secondNumber}={firstNumber - secondNumber}");
                    //        break;
                    //    case '+':
                    //        Console.WriteLine($"{firstNumber}+{secondNumber}={firstNumber + secondNumber}");
                    //        break;
                    //    case '*':
                    //        Console.WriteLine($"{firstNumber}*{secondNumber}={firstNumber * secondNumber}");
                    //        break;
                    //    case '/':
                    //        Console.WriteLine($"{firstNumber}/{secondNumber}={firstNumber / secondNumber}");
                    //        break;
                    //    default:
                    //        Console.WriteLine("Bad selected operator. Try again");
                    //        break;
                    //} // Išeina iš switch bet ne iš pačio ciklo begalinio.
                    if (simbol == '-')
                    {
                        Console.WriteLine($"{firstNumber}-{secondNumber}={firstNumber - secondNumber}");
                        break;

                    }
                    else if (simbol == '+')
                    {
                        Console.WriteLine($"{firstNumber}+{secondNumber}={firstNumber + secondNumber}");
                        break;
                    }
                    else if (simbol == '*')
                    {
                        Console.WriteLine($"{firstNumber}*{secondNumber}={firstNumber * secondNumber}");
                        break;
                    }
                    else if (simbol == '/')
                    {
                        Console.WriteLine($"{firstNumber}/{secondNumber}={firstNumber / secondNumber}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Bad selected operator. Try again");

                    }


                }
                while (true)
                {
                    Console.WriteLine("Do you want to continue? y/n");
                    string input4 = Console.ReadLine();
                    char decision = char.Parse(input4);
                    if (decision == 'n')
                    {
                        Console.WriteLine("You choose - No, bye");
                        sprendimas = false;
                        break;
                    }
                    else if (decision == 'y')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Bad input");

                    }

                }
               
            }
            while (sprendimas);









        }
    }
}
