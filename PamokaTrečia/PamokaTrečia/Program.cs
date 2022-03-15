using System;

namespace PamokaTrečia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //trečia pamoka 2022-03-10 Duomenų tipai Tipų Konversija
            //pvz
            //float numFloat = 1F/3;
            //double numDouble = 1D/3;
            //if (numFloat == numDouble)
            //{
            //    Console.WriteLine($"Skaičius float: ({numFloat}, skaičius Double: {numDouble}");
            //}
            //else
            //{
            //    Console.WriteLine($"Skaičius float: ({numFloat}, nėra lygus skaičiui Double: {numDouble}");
            //}
            ////stringai ir chars
            //char simbolis = 'j';
            // byte nuo 0-255
            //byte a = 0;
            //Console.WriteLine(a);
            //a++;
            //Console.WriteLine(a);
            //a = 254;
            //a++;
            //Console.WriteLine(a);
            //a++;
            //Console.WriteLine(a);

            //implicit casting
            //byte b = 57;
            //int i = b;
            //long l = i;
            //float f = l;
            //Console.WriteLine($"Byte:{b}");
            //Console.WriteLine($"int:{i}");
            //Console.WriteLine($"Long: {l}");
            //Console.WriteLine($"float: {f}"); 

            //Explicit casting:
            //double x = 123.4D;
            //int o;

            //o = (int) x;
            //covert klasė
            //int i = 12;
            //double d = 765.12D;
            //float f = 56.123F;
            //string convertedString=Convert.ToString(i);
            //int convertedInt = Convert.ToInt32(d);
            //double convertedDouble = Convert.ToDouble(f);   

            // užduotis Nr.1
            //Namų Darbai. papildoma užduotis padaryti ciklą begalinį tikrinant ar nėra įvesta raidė.

            //Console.WriteLine("Enter the distance, m");
            //double distance = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter durantion/Time, s");
            //double time = Convert.ToDouble(Console.ReadLine());
            //double timeInHour = time / 3600;
            //double speed = (distance/1000) / time;
            //Console.WriteLine($"Speed:{speed} Km/h");

            //Papildomai su begaliniu.

            //while (true)
            //{
            //    Console.WriteLine("Enter the distance, m");
            //    string input = Console.ReadLine();
            //    bool valid = Double.TryParse(input, out double distance);

            //    if (valid)
            //    {
            //        double distanceKm = distance / 1000;
            //        Console.WriteLine("Enter the travel time, seconds");
            //        string input2 = Console.ReadLine();
            //        bool valid1 = Double.TryParse(input2, out double time);
            //        if (valid1)
            //        {
            //            double timeH = time / 3600;
            //            double speed = distanceKm / timeH;
            //            Console.Write($"Travel speed:{speed} Km/h");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Wrong time input");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error, wrong distance input");
            //    }
            //}

            //Užduotis Nr.2 namų dabari pasidaryti su begaliniu ciklu ir patikra.
            //Console.WriteLine("enter the square length dimension");
            //double length =Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the square width dimensio");
            //double width = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the square height");
            //double height = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($"Square are = length * width ={length*width}");
            //Console.WriteLine($"Square volume = {length*width*height}");

            //užduotis Nr.3 

            //while (true)
            //{
            //    Console.WriteLine("Enter fisrt number:");
            //    string input = Console.ReadLine();
            //    bool valid = Double.TryParse(input, out double number1);

            //    if (valid)
            //    {
            //        Console.WriteLine("Enter second number");
            //        string input1 = Console.ReadLine();
            //        bool valid1=Double.TryParse(input1, out double number2);
            //        if (valid1)
            //        {

            //            bool numberEqual = number1 % 2d == 0d && number2 % 2d == 0;

            //            Console.WriteLine($"Numbers are equal/Skaičiai lyginiai: {numberEqual}");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bad input meaning, try again");
            //        }
            //    }

            //    else
            //    {
            //        Console.WriteLine("Bad Input meaning, try again");
            //    }

            //}
            // Atlikti 4 ir 5 užduotis kas buvo skirta namų darbams

            // Nauja paskaita If, If else, swicht
            //Condicition
            //Console.WriteLine("Enter the group name");
            //string groupName=Console.ReadLine();
            //Console.WriteLine("Enter the number of group members");
            ////int memberNumber= int.Parse(Console.ReadLine());
            //if(!int.TryParse(Console.ReadLine(),out int memberNumber))
            //{
            //    Console.WriteLine("Ivestas nekorektiškas skaičius");
            //    Environment.Exit(0);
            //}

            //pvz

            //SWICTH pvz

            //Console.WriteLine("Koki veiksmą norite atlitki");
            //Console.WriteLine("[1] istrinti vartotoja; [2] - sukurti vartotoja; [3] redaguoti esama vartoto");
            //int veiksmas=int.Parse(Console.ReadLine());

            //if (veiksmas == 1)
            //{
            //    Console.WriteLine("vartotojas yra ištrintas");
            //}
            //else if (veiksmas== 2)
            //{
            //    Console.WriteLine("Vartotojas yra sukurtas");

            //}
            //else if (veiksmas == 3)
            //{
            //    Console.WriteLine("Vartotojas pardaguotas");

            //}
            //else
            //{
            //    Console.WriteLine("Bloga įvestis");

            //}
            //switch (veiksmas)
            //{
            //    case 1: Console.WriteLine("Vartotojas yra ištrintas");
            //        break;
            //    case 2: Console.WriteLine("vartotojas yra sukurtas");
            //        break;
            //    case 3: Console.WriteLine("Vartotojas paredaguotas");
            //        break;
            //    default:
            //        Console.WriteLine("Nesuprantu komandos");
            //        break;
            //}
            // Savarankiškas darbas
            // Užduotis nr1
            //Console.WriteLine("Enter The member number of the band");
            //string input = Console.ReadLine();
            //bool aNumber=Int32.TryParse(input, out int number);

            //if (number == 1)
            //{
            //    Console.WriteLine("Tai solo atlikėjas");
            //}
            //else if (number == 2)
            //{
            //    Console.WriteLine("Tai duetas");
            //}
            //else if (number > 2 && number <= 10)
            //{
            //    Console.WriteLine("Tai Ansamblis");
            //}
            //else if (number >= 10)
            //{
            //    Console.WriteLine("Tai kamerinis ansamblis");
            //}
            //else if (aNumber == false)
            //{
            //    Console.WriteLine("Bloga įvestis");
            //Environment.Exit(0);
            //}

            //su Case
            //Console.WriteLine("Enter The member number of the band");
            //Console.WriteLine("[1]-Jei narių skaičius 1; [2]-jei narių skaičius 2; [3]- jei narių skaičius >2 ir <=10, [4]- jei narių skaičius >10");
            //string input = Console.ReadLine();
            //Int32.TryParse(input, out int number);
            //switch (number)
            //{
            //    case 1: Console.WriteLine("Tai solo atlikėjas");
            //        break;
            //    case 2: Console.WriteLine("Tai duetas");
            //        break;
            //    case 3: Console.WriteLine("Tai AnSamblis");
            //        break;
            //    case 4: Console.WriteLine("Tai kamerinis Ansamblos");
            //        break;
            //    default: Console.WriteLine("Bloga ivestis");
            //        break;
            //}

            // Užduotis Nr2 su IF
            //Console.WriteLine("Enter working Hour");
            //string input = Console.ReadLine();  
            //bool input2=Double.TryParse(input, out double hour);

            //if (hour < 160 && hour >0)
            //{
            //    double diference = 160 - hour;
            //    Console.WriteLine($"You mising {diference} working hour");

            //}
            //else if (hour > 160)
            //{
            //    double diference = 160 - hour;
            //    Console.WriteLine($"Your overtime is {diference}  hour");
            //}
            //else if (!input2)
            //{
            //    Console.WriteLine("Error, Bad inpurt");
            //    Environment.Exit(0);
            //}


            // Užduotis nr3
            Console.WriteLine("Enter the exam evaluation:");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int grade);
            switch (grade)
            {
                case 1: Console.WriteLine("Nepatenkinamai");
                    break;
                case 2:
                    Console.WriteLine("Nepatenkinamai");
                    break;
                case 3:
                    Console.WriteLine("Nepatenkinamai");
                    break;
                case 4:
                    Console.WriteLine("Nepatenkinamai");
                    break;
                case 5:
                    Console.WriteLine("Silpnai");
                    break;
                case 6:
                    Console.WriteLine("Patenkinamai");
                    break;
                case 7:
                    Console.WriteLine("Vidutiniškai");
                    break;
                case 8:
                    Console.WriteLine("Gerai");
                    break;
                case 9:
                    Console.WriteLine("Labai gerai");
                    break;
                case 10:
                    Console.WriteLine("Puiku");
                    break;
                default:
                    Console.WriteLine("Bad input");
                    break;












            }








        }
    }
}
