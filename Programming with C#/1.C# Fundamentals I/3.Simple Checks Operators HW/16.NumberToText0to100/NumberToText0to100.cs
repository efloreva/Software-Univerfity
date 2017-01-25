using System;

namespace _16.NumberToText0to100
{
    class NumberToText0to100
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int firstNumTenths = number / 10; //first number if less than 100
            int secondNumOnes = number % 10; //second number if less than 100

            if (number >100 || number <0) //checks for all other options outside of parameters
            {
                Console.WriteLine("invalid number");
            }
            if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            if (number >= 0 && number < 10 ) //till 10
            {
                switch (number % 10) //single number
                {
                    case 0: Console.WriteLine("zero"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }

            if (number >=10 && number <20)
            {
                // number % 100 last two nums
                switch (number % 100)
                {
                    case 10: Console.WriteLine("ten"); break;
                    case 11: Console.WriteLine("eleven"); break;
                    case 12: Console.WriteLine("twelve"); break;
                    case 13: Console.WriteLine("thirteen"); break;
                    case 14: Console.WriteLine("fourteen"); break;
                    case 15: Console.WriteLine("fifteen"); break;
                    case 16: Console.WriteLine("sixteen"); break;
                    case 17: Console.WriteLine("seventeen"); break;
                    case 18: Console.WriteLine("eighteen"); break;
                    case 19: Console.WriteLine("nineteen"); break;
                }
            }
            if (number >=20 && number <=99)
            {
               switch (firstNumTenths)
                {
                    case 2: Console.Write("twenty"); break; //just Write so they are 45 not 4 ~~ 5
                    case 3: Console.Write("thirty"); break;
                    case 4: Console.Write("fourty"); break;
                    case 5: Console.Write("fifty"); break;
                    case 6: Console.Write("sixty"); break;
                    case 7: Console.Write("seventy"); break;
                    case 8: Console.Write("eighty"); break;
                    case 9: Console.Write("ninety"); break;
                }

               switch (secondNumOnes) //second number
               {
                   case 1: Console.WriteLine(" one"); break; //added space to separate the two words
                   case 2: Console.WriteLine(" two"); break;
                   case 3: Console.WriteLine(" three"); break;
                   case 4: Console.WriteLine(" four"); break;
                   case 5: Console.WriteLine(" five"); break;
                   case 6: Console.WriteLine(" six"); break;
                   case 7: Console.WriteLine(" seven"); break;
                   case 8: Console.WriteLine(" eight"); break;
                   case 9: Console.WriteLine(" nine"); break;
               }
            }
        }
    }
}
