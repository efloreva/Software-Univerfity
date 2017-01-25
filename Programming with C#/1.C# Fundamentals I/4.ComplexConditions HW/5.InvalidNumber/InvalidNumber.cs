using System;

namespace _5.InvalidNumber
{
    class InvalidNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            var inRange = (number >= 100 && number <= 200) || (number == 0);
            //bool type ^ not int or double
            if (!inRange)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
