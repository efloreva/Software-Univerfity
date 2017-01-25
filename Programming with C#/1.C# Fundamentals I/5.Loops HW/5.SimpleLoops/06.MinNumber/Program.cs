using System;

namespace _05.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {

                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum < min)
                {
                    min = currentNum;
                }
            }
            Console.WriteLine(min);
        }
    }
}
