using System;

namespace AntraPamoka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Antra pamoka TEMA: Kintamieji
            //Užduotis Nr.1

            //int yearOfBirth; //Inicializacija
            //string firstName;

            //var lastName = "Miklovas";//deklaruojam
            //decimal salary = 10m; //darbui su pinigais
            //double income = 5000d; //darbui su skaičiams su liekana

            //yearOfBirth = 1989; //Reikšmės priskyrimas
            //firstName = "Valdas";
            //DateTime lastPayDay = new DateTime(2022, 03, 07);
            //DateTime date = DateTime.Today.AddDays(2);

            //Console.WriteLine($"First name:{firstName}, Last name:{lastName}, Year of birth:{yearOfBirth}");

            //Užduotis nr1

            // Užduotis Nr.2
            //string schoolName;
            //string courseName;
            //int studentNumber;

            //schoolName = "Code Acadamy";
            //courseName = ".Net mokymai";
            //DateTime date = DateTime.Today;

            //Console.WriteLine($"School - {schoolName} ");
            //Console.WriteLine($"Course -  {courseName}");
            //Console.WriteLine($"Date -  {date}");

            // Užduotis Nr.3
            //string schoolname;
            //string coursename;
            //int studentnumber;

            //schoolname = "code acadamy";
            //coursename = ".net mokymai";
            //datetime date = datetime.today;
            //datetime startdate = new datetime(2022, 03, 01);
            //datetime enddate = new datetime(2022, 10, 21);
            //double  totaldays = (enddate - startdate).totaldays;
            //double weeks = totaldays / 7;
            //double workdays = totaldays - (weeks * 3);
            ////string dateformat = date.tolongdatestring("mm/dd/yyyy"); //-datos formatavimui


            //console.writeline($"school - {schoolname} ");
            //console.writeline($"course -  {coursename}");
            //console.writeline($"today day - {date}");
            //console.writeline($"start date -  {startdate}");
            //console.writeline($"end date - {enddate}");
            //console.writeline($"course days - {totaldays}");
            //console.writeline($"weeks numbers - {weeks}");
            //console.writeline($"days without friday and weekends - {workdays}");

            //Užduotis Nr4

            //Console.WriteLine("Enter first Number");
            //string input1 = Console.ReadLine();

            //bool isNumber  = Int32.TryParse(input1, out int number1);
            //if(isNumber)
            //{
            //    Console.WriteLine("Enter first Number");
            //    string input2 = Console.ReadLine();
            //    bool isNumber2 = Int32.TryParse(input2,out int number2);

            //    if (isNumber2)
            //    {
            //        bool equal = number1 == number2;

            //        Console.WriteLine($" Is Numbers {number1} and {number2} is equal? {equal}");
            //    }

            //    else
            //    {
            //        Console.WriteLine("bad input2");
            //    }


            //}
            //else
            //{
            //    Console.WriteLine("Bad input1");
            //}

            //Užduotis Nr5
            //su begaliniu ciklu

            //bool valid = true;

            //do
            //{
            //    Console.WriteLine("Enter the first number");
            //    string iput1 = Console.ReadLine();
            //    bool isThisNumber1 = Int32.TryParse(iput1, out int number1);
            //    if (isThisNumber1)
            //    {
            //        Console.WriteLine("Enter the second number");
            //        string input2 = Console.ReadLine();
            //        bool isThisNumber2 = Int32.TryParse(input2, out int number2);

            //        if (isThisNumber2)
            //        {
            //            number1++;
            //            number2--;

            //            Console.WriteLine($"First number: {number1}");
            //            Console.WriteLine($"Second number: {number2}");
            //            valid = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Wrong input");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong input");

            //    }

            //}
            //while (valid);


            //užduotis be begalinio ciklo.

            //Console.WriteLine("Enter the first number");
            //string iput1 = Console.ReadLine();
            //bool isThisNumber1 = Int32.TryParse(iput1, out int number1);
            //if (isThisNumber1)
            //{
            //    Console.WriteLine("Enter the second number");
            //    string input2 = Console.ReadLine();
            //    bool isThisNumber2 = Int32.TryParse(input2, out int number2);

            //    if (isThisNumber2)
            //    {
            //        number1++;
            //        number2--;

            //        Console.WriteLine($"First number: {number1}");
            //        Console.WriteLine($"Second number: {number2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong input");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Wrong input");
            //}

            //Užnduotis Nr.6



            //Console.WriteLine("enter text");
            //string text = Console.ReadLine();
            //bool isempty = text == string.Empty;
            //if (isempty)
            //{
            //    Console.WriteLine($"Line is Empty->{isempty}");

            //}
            //else
            //{
            //    Console.WriteLine($"Line is Empty -> {isempty}");
            //}

            // Užduotis Nr7

            //bool valid = true;
            //do
            //{
            //    Console.WriteLine("Enter the number");
            //    string input = Console.ReadLine();


            //    bool number = Double.TryParse(input, out double number1);


            //    if (number)
            //    {
            //        bool result = number1 < 0;
            //        Console.WriteLine($"Does {number1}<0, {result}");
            //        valid = false;

            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong input");
            //    }
            //}
            //while (valid);

            //Užduotis Nr8.

            bool valid = true;
            string userFirstName = "Valdas";
            string userLastName = "Miklovas";
            //StringCimparison.OrdinalIgnoreCase

            
            do
            {
                Console.WriteLine("Enter the User first Name:");
                string inputUserFirstName = Console.ReadLine();
                Console.WriteLine("Enter the Usere Last Name");
                string inputUserLastName = Console.ReadLine();
                if (string.Equals(userFirstName,inputUserFirstName,StringComparison.OrdinalIgnoreCase)||string.Equals(userLastName,inputUserLastName,StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Match, you connected");
                    valid = false;
                }

                else
                {
                    Console.WriteLine("User First Name or Last Name incorrect. Try again");
                }

            }
            while (valid);






        }
    }
}
