using System;

namespace _10.Number100To200
{
    class Number100To200
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            if (inputNum < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (inputNum >= 100 && inputNum <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (inputNum > 200)
            {
                Console.WriteLine("Greater than 200");

            }


        }
    }
}
