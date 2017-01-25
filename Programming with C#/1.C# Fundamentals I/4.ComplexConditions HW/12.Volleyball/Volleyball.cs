using System;

namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main()
        {
            string year = Console.ReadLine().ToLower();
            int vacationDays = int.Parse(Console.ReadLine()); //no weekends
            int travelWeekends = int.Parse(Console.ReadLine()); //weekends he travels to home

            int weekends = 48; //total - travelWeekends = weekendsInSofia
            int weekendsInSofia = weekends - travelWeekends;

            double playTime = weekendsInSofia * 3.0 / 4 + travelWeekends + vacationDays*2.0/3; //Saturdays play time in Sofia and Home
            double leapBonus = 0.15 * playTime;

            if (year == "leap")
            {
                playTime += leapBonus;
                Console.WriteLine(Math.Floor(playTime));
            }
            else if (year == "normal")
            {
                Console.WriteLine(Math.Floor(playTime));
            }
        }
    }
}
