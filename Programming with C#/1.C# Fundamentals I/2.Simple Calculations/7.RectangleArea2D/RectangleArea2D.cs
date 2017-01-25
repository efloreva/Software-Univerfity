using System;

namespace _7._2DRectangleArea
{
    class RectangleArea2D
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine()); // 60
            var y1 = double.Parse(Console.ReadLine()); // 20
            var x2 = double.Parse(Console.ReadLine()); // 10
            var y2 = double.Parse(Console.ReadLine()); // 50
            //area = a*b t.e. 50*30
            //perimeter = 2*(a+b) t.e. 2*(50+30)

            var a = Math.Abs(x1 - x2); ///math.ABS absolutna stoinost. 
            var b = Math.Abs(y1 - y2);
            Console.WriteLine(a * b); //area
            Console.WriteLine(2 * (a + b)); //perimeter
        }
    }
}
