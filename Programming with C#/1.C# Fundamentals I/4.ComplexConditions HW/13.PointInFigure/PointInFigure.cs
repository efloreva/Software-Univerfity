using System;

namespace _13.PointInFigure
{
    class PointInFigure
    {
        static void Main() //0 2h 4h 3h
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 0;
            int y1 = 0;
            int x2 = 2 * h;
            int y2 = 4 * h;

            int x3 = 3 * h; //two different rectangles with some common borders
            string result = "";

            if ((x < h && y > h) || (x > x2 && y > h) || (x < x1) || (x > x3) || (y < y1) || (y > y2))
            {
                result = "outside";
            }
            else if ((x > x1 && x < x3 && y > y1 && y < h) || (x > h && x < x2 && y < y2 && y > y1))
            {
                result = "inside";
            }
            else
            {
                result = "border";
            }
            Console.WriteLine(result);
        }
    }
}