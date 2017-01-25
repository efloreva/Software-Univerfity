using System;
namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num1 = 0; //if = 1 then in the for{i<n-1} In reality it is going to activate n-2 times
            int num2 = 1;
            int sum = 0;

            if (n < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    sum = num1 + num2;
                    num1 = num2;
                    num2 = sum;
                }
                Console.WriteLine(num2);
            }
        }
    }
}
