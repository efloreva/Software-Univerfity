using System;
namespace _14.NumberTableMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine()); // Diagonal matrix simetrichna

            for (int row = 1; row <= inputNum; row++)
            {
                int increase = row; //from smallest num up
                int decrease = inputNum; //from biggest num down

                for (int col = 1; col <= inputNum; col++)
                {
                    if (increase < inputNum)//smalest < n
                    {//just Write to make it a matrix
                        Console.Write(increase + " "); 
                        increase++; // prints 1 2 3
                    }
                    else
                    {
                        Console.Write(decrease + " ");
                        decrease--; // prints 3 2 1
                    }
                }
                Console.WriteLine(); //new line
            }
        }
    }
}
