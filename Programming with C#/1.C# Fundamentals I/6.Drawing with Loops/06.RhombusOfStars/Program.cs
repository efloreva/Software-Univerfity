using System;
namespace _06.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //upper
            for (int row = 1; row <= n; row++)
            {

                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            //lower

            for (int row = n; row >= 1; row--)
            {
                for (int col = n-row; col >= 1; col--)
                {
                    Console.Write(" ");
                }
                //Console.Write("*");   no need for that extra line in the middle
                for (int col = row; col > 1; col--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}