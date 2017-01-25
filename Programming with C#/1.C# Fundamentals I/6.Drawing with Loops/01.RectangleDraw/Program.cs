using System;

namespace _01.RectangleDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('*',10));
            }


            //or
            Console.WriteLine();
            Console.WriteLine();
            //or

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*"); //just Write for horizontal stars
                }
                Console.WriteLine(); // for new line on each horizontal row
            }
        }
    }
}
