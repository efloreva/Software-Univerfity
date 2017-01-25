using System;
namespace _10.HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int max = 0;
            int allSum = 0;


            // изчислете сумата на всички елементи и най-големият от тях и проверете търсеното условие.
            for (int i = 0; i < number; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                allSum += currentNum;

                if (currentNum > max)
                {
                    max = currentNum;
                }
            }

            int remainingSum = allSum - max;

            int difference = Math.Abs(max - remainingSum);

            if (max == remainingSum)
            {
                Console.WriteLine("Yes Sum = " + max);
            }
            else Console.WriteLine("No Diff = " + difference);

        }
    }
}
