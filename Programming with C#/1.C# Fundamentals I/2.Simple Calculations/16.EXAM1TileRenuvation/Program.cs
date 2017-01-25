using System;                                          //EXAM 24 April 2016

namespace _1.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int sidesN = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLenght = double.Parse(Console.ReadLine());
            int benchMwidth = int.Parse(Console.ReadLine());
            int benchOlenght = int.Parse(Console.ReadLine());

            double timeTile = 0.2; //mins per tile

            int area = sidesN * sidesN;
            int benchArea = benchMwidth * benchOlenght;

            int totileArea = area - benchArea;

            double oneTileArea = tileWidth * tileLenght;

            double tilesNeeded = totileArea / oneTileArea;

            double timeTotal = tilesNeeded * timeTile;

            Console.WriteLine(tilesNeeded);
            Console.WriteLine(timeTotal);
        }
    }
}
