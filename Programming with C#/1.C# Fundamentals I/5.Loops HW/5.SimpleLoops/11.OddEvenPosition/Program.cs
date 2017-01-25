using System;

namespace _11.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            double oddSum = 0.0;
            double oddMin = double.MaxValue; // ??
            double oddMax = double.MinValue;
            double evenSum = 0.0;
            double evenMin = double.MaxValue;  // ??
            double evenMax = double.MinValue;


            for (int i = 1; i <= numbers; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currentNum;

                    if (currentNum > evenMax)
                    {
                        evenMax = currentNum;
                    }
                    if (currentNum < evenMin)
                    {
                        evenMin = currentNum;
                    }
                }
                else
                {
                    oddSum += currentNum;

                    if (currentNum > oddMax)
                    {
                        oddMax = currentNum;
                    }
                    if (currentNum < oddMin)
                    {
                        oddMin = currentNum;
                    }
                }
            }


            if (numbers == 0)
            {
                Console.WriteLine("OddSum = 0, OddMin = No, OddMax = No, EvenSum = 0, EvenMin = No, EvenMax = No");
            }
            else if (numbers == 1)
            {
                Console.WriteLine("Oddsum = " + oddSum);
                Console.WriteLine("Oddmin = " + oddMin);
                Console.WriteLine("Oddmax = " + oddMax);
                Console.WriteLine("EvenSum = 0");
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine("OddSum = {0}, OddMin = {1}, OddMax = {2}, EvenSum = {3}, EvenMin = {4}, EvenMax = {5}", oddSum, oddMin, oddMax,
                evenSum, evenMin, evenMax);
            }
            //Alternatively: if there are no changes in the values (not the sums)

/* Console.WriteLine("OddSum = " + oddSum);            
            if (oddMin == double.MaxValue) Console.WriteLine("OddMin = No");
            else Console.WriteLine("OddMin = " + oddMin);
            if (oddMax == double.MinValue) Console.WriteLine("OddMax = No");
            else Console.WriteLine("OddMax = " + oddMax);
            Console.WriteLine("EvenSum  = " + evenSum);            
            if (evenMin == double.MaxValue) Console.WriteLine("EvenMin = No");
            else Console.WriteLine("EvenMin = " + evenMin);
            if (evenMax == double.MinValue) Console.WriteLine("EvenMax = No");
            else Console.WriteLine("EvenMax  =" + evenMax);
 */
        }
    }
}

