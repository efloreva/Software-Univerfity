using System;

namespace _4.GreaterNumber
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else {
                Console.WriteLine(b);
            }
        }
    }
}
