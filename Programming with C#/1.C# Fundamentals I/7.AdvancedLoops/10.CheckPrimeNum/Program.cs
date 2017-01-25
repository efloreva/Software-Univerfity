using System;
namespace _10.CheckPrimeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool checkNotPrime = false;

            if (n < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 2; i <= Math.Truncate(Math.Sqrt(n)); i++)
                {
                    if (n % i == 0 || n%n == 0) //devide by itself and i
                    {
                        checkNotPrime = true;
                    }
                    else checkNotPrime = false;
                }
                if (checkNotPrime == true)
                {
                    Console.WriteLine("Not Prime");
                }
                else Console.WriteLine("Prime");
            }
        }
    }
}
