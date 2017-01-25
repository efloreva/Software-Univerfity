using System;

namespace _02.NumbersEndingIn7
{
    class NumbersEndingIn7
    {
        static void Main(string[] args)
        { //or     i = 0; i <= 1000; i++
        //or      //i = 7; i <= 1000 ; i +=10
            for (int i = 6; i <= 997; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
