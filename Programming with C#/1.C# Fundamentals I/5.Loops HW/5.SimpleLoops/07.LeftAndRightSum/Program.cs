using System;

namespace _07.LeftAndRightSum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentLeftNum = int.Parse(Console.ReadLine());
                leftSum += currentLeftNum;
            }

            for (int i = 0; i < n; i++)
            {
                int currentRightNum = int.Parse(Console.ReadLine());
                rightSum += currentRightNum;
            }

            int difference = Math.Abs(leftSum - rightSum);

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else Console.WriteLine("No, diff = " + difference);
        }
    }
}
