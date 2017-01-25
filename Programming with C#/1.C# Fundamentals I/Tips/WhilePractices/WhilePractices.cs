using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_A_u
{
    class WhilePractices
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().ToLower();
            int num = int.Parse(Console.ReadLine());

            while (command != "end")
            {
                //do the following code and stop at the End
            }
            int num = 0;
            while (num < 1 || num > 100) // get a new number if invalid
            {
                if (num%2==0) //example
                {
                    break;
                }

                Console.WriteLine("invalid num");
                //int num = int.Parse(Console.ReadLine());
                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
