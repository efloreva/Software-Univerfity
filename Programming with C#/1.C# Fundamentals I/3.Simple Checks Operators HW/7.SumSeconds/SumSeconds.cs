using System;

namespace _7.SumSeconds
{
    class SumSeconds
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int secondsSum = num1 + num2 + num3;
            int minutes = secondsSum / 60;  //turns them into minutes
            int seconds = secondsSum % 60; //returns the ostatak

            Console.WriteLine("{0}:{1:00}", minutes, seconds);
        }
    }
}
