using System;
namespace _04.TriangleOfCash
{
    class Program
    {
        static void Main(string[] args)
        {
            // два вложени цикъла: за първия row = 1 … n; за втория col = 1 … row.

            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++) // with =
            {
                for (int col = 1; col <= row; col++) //with =
                {
                    Console.Write("$ "); // with space
                }
                Console.WriteLine();
            }

        }
    }
}
