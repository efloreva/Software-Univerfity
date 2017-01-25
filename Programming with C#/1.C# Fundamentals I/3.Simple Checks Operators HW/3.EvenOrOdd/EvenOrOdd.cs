using System;

namespace _3.EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            var even = (num % 2 == 0);
            if (even)
            {
                Console.WriteLine("Even");
            }
            else {
                Console.WriteLine("Odd");
            }
        }
    }
}
