using System;

namespace _13.AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main()
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(side*side);
            }
            else if (figure == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine(side1 * side2);
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * radius * radius,3));
            }
            else if (figure == "triangle")
            {
                double height = double.Parse(Console.ReadLine());
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine((height * side) /2);
            }
        }
    }
}
