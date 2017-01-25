using System;

namespace _5.Trapeziod_Area
{
    class TrapezoidArea
    { //(b1 + b2) * h / 2.
        static void Main(string[] args)
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine((b1+b2)*h/2);
        }
    }
}
