using System;

namespace _6.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            double score = double.Parse(Console.ReadLine());
            double bonusScore = 0;
            double finalScore = 0;
            
            if (score <= 100)
            {
                bonusScore += 5;

            } else if (score >100 && score <1000)
            {
                bonusScore = 20*score/100;

            } else if (score >1000)
            {
                bonusScore = 10*score/100;
            }

            if (score % 2 == 0) //Even bonus +1t
            {
                bonusScore += 1;
            }
            else if (score % 10 == 5)  //Numbers ending in 5 +2t.
            {
                bonusScore += 2;
            }

            finalScore = score + bonusScore;

            Console.WriteLine(bonusScore);
            Console.WriteLine(finalScore);
        }
    }
}
