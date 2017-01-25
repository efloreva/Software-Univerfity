using System;
namespace _05.Sequence2KPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 0; i < n; i++)
            {
                if (num <= n) //key to print all of the right numbers
                {
                    Console.WriteLine(num);
                    num = (num * 2) + 1; //right after the printing it num changes
                }
            }
        }
    }
}
