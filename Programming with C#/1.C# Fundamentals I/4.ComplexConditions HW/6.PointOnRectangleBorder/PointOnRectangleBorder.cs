using System;

namespace _6.PointOnRectangleBorder
{
    class PointOnRectangleBorder
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            string result = "";

            bool topBorder = (y == y1) && (x >= x1 && x <= x2); // the && and not ||
            bool bottomBorder = (y == y2) && (x >= x1 && x <= x2);
            bool leftBorder = (x == x1) && (y >= y1 && y <= y2);
            bool rightBorder = (x == x2) && (y >= y1 && y <= y2);

            if (topBorder || bottomBorder || leftBorder || rightBorder)
            {
                result = "Border";
            }
            else result = "Inside / Outside";

            Console.WriteLine(result);
        }
    }
}
