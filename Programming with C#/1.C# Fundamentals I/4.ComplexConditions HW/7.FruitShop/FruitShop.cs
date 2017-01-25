using System;

namespace _7.FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string produce = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double amount = double.Parse(Console.ReadLine());

            double price = 0.0;

            if (day == "monday" ||
                day == "tuesday" ||
                day == "wednesday" ||
                day == "thursday" ||
                day == "friday")
            {
                //fruit checks
                if (produce == "banana") price = 2.50;
                else if (produce == "apple") price = 1.20;
                else if (produce == "orange") price = 0.85;
                else if (produce == "grapefruit") price = 1.45;
                else if (produce == "kiwi") price = 2.70;
                else if (produce == "pineapple") price = 5.50;
                else if (produce == "grapes") price = 3.85;

            } else if (day == "saturday" || day == "sunday")
            {
                if (produce == "banana") price = 2.70;
                else if (produce == "apple") price = 1.25;
                else if (produce == "orange") price = 0.90;
                else if (produce == "grapefruit") price = 1.60;
                else if (produce == "kiwi") price = 3.00;
                else if (produce == "pineapple") price = 5.60;
                else if (produce == "grapes") price = 4.20;
            }
            else Console.WriteLine("error");

            if (price == 0.0)
            {
                Console.WriteLine("error");
            }
            else Console.WriteLine("{0:F2}", price * amount);
        }
    }
}
