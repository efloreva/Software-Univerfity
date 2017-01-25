using System;

namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //2<= N <=100
            if (2<= n && n<=100)
            {
            Console.WriteLine(new string('*',n));

            for (int i = 0; i < n-2; i++) // determine space inside
            {
                Console.Write("*");                  //without Line
                Console.Write(new string(' ', n-2)); // wintout Line
                Console.WriteLine("*");              //with Line
            }
            Console.WriteLine(new string('*', n));            
            }
            Console.WriteLine("Invalid input number");
        }
    }
}
