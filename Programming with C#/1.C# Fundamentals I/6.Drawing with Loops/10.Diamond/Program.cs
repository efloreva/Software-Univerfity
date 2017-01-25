using System;
namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            int middleDashes = 1;
            int outerDashes = (n - 1) / 2;

            if (n == 1)
            {
                Console.WriteLine("*");
                return;
            }
            if (n == 2)
            {
                Console.WriteLine("**");
                return;
            }
            if (n % 2 == 0)
            {
                stars = 2; // for even number **, for odd number *
                middleDashes = 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('-', outerDashes), new string('*', stars)); // first line
            outerDashes--; // so the stars move relatively to the N romb shape

            //top part
            for (int row = 0; row < (n - 1) / 2; row++)
            {

                Console.WriteLine("{0}*{1}*{0}", new string('-', outerDashes), new string('-', middleDashes));
                middleDashes += 2; // to make it *---*
                outerDashes--;
            }

            middleDashes -= 4;             //to retain symbol count and handle Out or Range exception
            outerDashes += 2;

            //bottom part
            for (int i = 1; i < (n - 1) / 2; i++) //start from 1 to miss one extra line
            {
                Console.WriteLine("{0}*{1}*{0}", new string('-', outerDashes), new string('-', middleDashes));
                middleDashes -= 2;
                outerDashes++;
            }

            Console.WriteLine("{0}{1}{0}", new string('-', outerDashes), new string('*', stars)); // last line
        }
    }
}
