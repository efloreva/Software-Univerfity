using System;

namespace _9.CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double farenheit = celsius * 1.8 + 32;
            Console.WriteLine(Math.Round(farenheit, 2));
        }
    }
}
