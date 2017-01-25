using System;

namespace _11.USDToBGN
{
    class USDToBGN
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            var course = 1.79549;
            var bgn = usd * course;
            Console.WriteLine(Math.Round(bgn,2) + " BGN");
        }
    }
}
