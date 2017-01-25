using System;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main()
        {
            string screeningType = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            
            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5.00;

            double result = 0; // изчислява общите приходи от билети при пълна зала

            if (screeningType == "premiere")
            {
                result = row * col * premiere;
            }
            else if (screeningType == "normal")
            {
                result = row * col * normal;
            }
            else if (screeningType == "discount")
            {
                result = row * col * discount;
            }

            if (result < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:f2} leva",result);
            }
        }
    }
}
