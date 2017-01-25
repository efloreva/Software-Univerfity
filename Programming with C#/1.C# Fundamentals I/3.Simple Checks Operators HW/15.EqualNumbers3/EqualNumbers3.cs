using System;

namespace _15.EqualNumbers3
{
    class EqualNumbers3
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("yes");
            }else
            {       
                Console.WriteLine("no");
         	}
            
        }
    }
}
