using System;

namespace _1.Exam1TrainingLab                               //EXAM 6 March 2016
{
    class Exam1TrainingLab
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double wide = double.Parse(Console.ReadLine());

            lenght = lenght * 100; //to turn in cm
            wide = wide * 100 - 100; // to turn in cm minus the corridor 100

            double rows = Math.Floor(lenght / 120); //as per the task instructions

            double desks = Math.Floor(wide / 70); //as per the task instructions

            double seatNumber = rows * desks - 3; //as per the task instructions

            Console.WriteLine(seatNumber);
        }
    }
}
