using System;

namespace _4.FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main(string[] args)
        {
            string goods = Console.ReadLine().ToLower();
            //string result = "";
            if (goods == "banana" ||
                goods == "apple" ||
                goods == "kiwi" ||
                goods == "cherry" ||
                goods == "lemon" ||
                goods == "grapes")
            {
                Console.WriteLine("fruit");
                // restult = "fruit"
            }
            else if (goods == "tomato" ||
                goods == "cucumber" ||
                goods == "pepper" ||
                goods == "carrot")
            {
                Console.WriteLine("vegetable");
                // restult = "vegetable"
            }
            else
            {
                Console.WriteLine("unknown");
                // restult = "unknown"
            }
           // Console.WriteLine(result);
        }
    }
}
