using System;

namespace _05.SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            if (n <= 2)
            {
                Console.WriteLine("+ +");
                Console.WriteLine("+ +");
            }
            else
            {
                // start line
                Console.Write("+ ");
                for (int a = 0; a < n - 2; a++)
                {
                    Console.Write("- ");
                }
                Console.Write("+");
                Console.WriteLine();

                if (n >= 4)
                {
                    for (int b = 0; b < n - 2; b++)
                    {
                        //middle lines
                        Console.Write("| ");
                        for (int a = 0; a < n - 2; a++)
                        {
                            Console.Write("- ");
                        }
                        Console.Write("|");
                        Console.WriteLine();
                    }
                }
                else
                {
                    //middle lines
                    Console.Write("| ");
                    for (int a = 0; a < n - 2; a++)
                    {
                        Console.Write("- ");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }


                //end line
                Console.Write("+ ");
                for (int a = 0; a < n - 2; a++)
                {
                    Console.Write("- ");
                }
                Console.Write("+");
                Console.WriteLine();
            }
        }
    }
}
