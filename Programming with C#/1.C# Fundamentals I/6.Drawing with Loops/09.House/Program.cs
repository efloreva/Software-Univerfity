using System;

namespace _1.Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countStars = 1;

            if (n % 2 == 0)
            {
                countStars = 2;
            }
            //rooftop
            for (int row = 0; row < (n + 1) / 2; row++)
            { //with Write only
                Console.Write(new string('-', (n - countStars) / 2));
                Console.Write(new string('*', countStars));
                Console.Write(new string('-', (n - countStars) / 2));
                Console.WriteLine();
                countStars = countStars + 2; //to make the lines and stars correspond !

                /*   expected result example with 7 and not -------*------- on all rows/lines
                      ---*---
                      --***--
                      -******-
                      ********
                */
            }
            for (int row = 0; row < n / 2; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
        }
    }
}
