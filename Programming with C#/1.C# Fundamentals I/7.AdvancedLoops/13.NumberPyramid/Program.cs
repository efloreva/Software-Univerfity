using System;
namespace _13.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int row = 1; row <= inputNum; row++) // with =
            {
                for (int col = 1; col <= row; col++) //with =
                {
                    counter ++;
                    Console.Write(counter + " "); // with space
                    if (counter == inputNum)  return;
                }
               
                Console.WriteLine(); // new line
            }            
        }
    }
}
