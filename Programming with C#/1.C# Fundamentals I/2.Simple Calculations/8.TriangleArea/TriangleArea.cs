using System;

namespace _8.TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {

            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double triArea = side * height / 2;
            Console.WriteLine(Math.Round(triArea,2));
        }

    }
}