using System;

namespace _04.SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            // or i = 1; i <= n
            for (int i = 0; i < n; i++)
            {
                int nForSum = int.Parse(Console.ReadLine());

                sum += nForSum;
            }
            Console.WriteLine(sum);
        }
    }
}
