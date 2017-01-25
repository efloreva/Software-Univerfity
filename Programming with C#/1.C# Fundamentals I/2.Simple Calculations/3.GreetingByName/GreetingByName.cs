using System;

namespace GreetingByName
{
    class GreetingByName
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            //Console.Clear();
            Console.WriteLine("Hello, {0}!",name);
        }
    }
}
//judge system is not accepting this atm