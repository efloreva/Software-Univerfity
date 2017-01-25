using System;
namespace _06.NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            int n = int.Parse(Console.ReadLine());


            if (n < 1 || n > 100)
            {
                for (int i = 0; i < n || i > n; i++) // can put one OR other in FOR
                {
                    Console.WriteLine("Invalid number");
                    Console.Write("Еnter a number in the range [1...100]: ");
                    n = int.Parse(Console.ReadLine());

                    if (n > 0 && n < 101) // [1..100]
                    {
                        Console.WriteLine("The number is: {0}", n); break;
                    }

                }
            } else if (n > 0 && n < 101)
            {
                Console.WriteLine("The number is: {0}", n);
            }
        }
    }
}
