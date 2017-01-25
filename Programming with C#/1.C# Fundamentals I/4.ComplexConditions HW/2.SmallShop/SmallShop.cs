using System;

namespace _2.SmallShop
{
    class SmallShop
    {
        static void Main()
        {
            string goods = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (goods == "coffee")
                {
                    Console.WriteLine(amount * 0.50);
                }
                else if (goods == "water")
                {
                    Console.WriteLine(amount * 0.80);
                }
                else if (goods == "beer")
                {
                    Console.WriteLine(amount * 1.20);
                }
                else if (goods == "sweets")
                {
                    Console.WriteLine(amount * 1.45);
                }
                else if (goods == "peanuts")
                {
                    Console.WriteLine(amount * 1.60);
                }
            }
            else if (city == "Plovdiv")
            {
                if (goods == "coffee")
                {
                    Console.WriteLine(amount * 0.40);
                }
                else if (goods == "water")
                {
                    Console.WriteLine(amount * 0.70);
                }
                else if (goods == "beer")
                {
                    Console.WriteLine(amount * 1.15);
                }
                else if (goods == "sweets")
                {
                    Console.WriteLine(amount * 1.30);
                }
                else if (goods == "peanuts")
                {
                    Console.WriteLine(amount * 1.50);
                }
            }
            else if (city == "Varna")
            {
                if (goods == "coffee")
                {
                    Console.WriteLine(amount * 0.45);
                }
                else if (goods == "water")
                {
                    Console.WriteLine(amount * 0.70);
                }
                else if (goods == "beer")
                {
                    Console.WriteLine(amount * 1.10);
                }
                else if (goods == "sweets")
                {
                    Console.WriteLine(amount * 1.35);
                }
                else if (goods == "peanuts")
                {
                    Console.WriteLine(amount * 1.55);
                }
            }
        }
    }
}
