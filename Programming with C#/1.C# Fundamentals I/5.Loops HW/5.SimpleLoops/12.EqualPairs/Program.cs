using System;

namespace _12.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPairs = int.Parse(Console.ReadLine());

            int sumPair = 0;
            int maxDifference = int.MinValue;

    //        var firstCouple = int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberPairs; i++) // from 1 to the N 
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int currentDiff = Math.Abs(sumPair - num1 - num2);

                if (i != 1)
                { //If there is any difference of the numbers, it to be taken by the maxDiff.
                    if ((currentDiff != 0) && (maxDifference < currentDiff)) 
                    { //any diff? & if diff is bigger 
                        maxDifference = currentDiff;
                    }
                }
                sumPair = num1 + num2; // if there is no difference aka currentDiff == 0 
            }

            /* Checks ^ 
            Printing result below. */

            if (maxDifference == int.MinValue) //if unchanged - Yes
            {
                Console.WriteLine("Yes, value={0}", sumPair);
            }
            else //No
            {
                Console.WriteLine("No, maxdiff={0}", maxDifference);
            }
        }
    }
}
