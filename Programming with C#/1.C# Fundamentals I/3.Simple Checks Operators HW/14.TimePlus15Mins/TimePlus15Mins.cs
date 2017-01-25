using System;

namespace _14.TimePlus15Mins
{
    class TimePlus15Mins
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int current = minutes + 15;
            int newMins = 0;

            if (current > 59)
            {
                hours += 1;
                newMins = current - 60; //gives the minutes passed from the new hours

                if (hours > 23) hours = 0; //turns 24 hours to 0

                if (newMins < 10)
                {
                    Console.WriteLine("{0}:0{1}", hours, newMins);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", hours, newMins);
                }
            }else
            {
                Console.WriteLine("{0}:{1}", hours, current);
            }
        }
    }
}
