using System;

namespace _08.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (i % 2 == 0) //even number places
                {
                    evenSum += currentNum;
                }
                else oddSum += currentNum;
            }

            int difference = Math.Abs(oddSum - evenSum);

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes, sum = " + oddSum);
            }
            else Console.WriteLine("No, diff = " + difference);
        }
    }
}