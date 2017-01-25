using System;                                            //EXAM 26 March 2016

namespace _1.Exam1VeggieStore
{
    class Exam1VeggieStore
    {
        static void Main(string[] args)
        {
            double vegPrice = double.Parse(Console.ReadLine());
            double fruPrice = double.Parse(Console.ReadLine());

            int vegKilos = int.Parse(Console.ReadLine());
            int fruKilos = int.Parse(Console.ReadLine());

            double result = ((vegPrice * vegKilos) + (fruPrice * fruKilos)) / 1.94; // in EUR

            Console.WriteLine(result);
        }
    }
}
