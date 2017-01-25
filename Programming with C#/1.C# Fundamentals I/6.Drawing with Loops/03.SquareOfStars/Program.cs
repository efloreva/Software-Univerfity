using System;
namespace _03.SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) // with =
            {
                Console.Write("*"); //just Write to stick it with the lower line horizontally
                for (int j = 1; j < n; j++)  //without =  
                {
                    Console.Write(" *");
                }
                Console.WriteLine(); // new line after each horizontal line is done
            }
        }
    }
}
