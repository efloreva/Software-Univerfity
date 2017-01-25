using System;

namespace _11.EqualWords
{
    class EqualWords
    {
        static void Main()
        {// make them all in UPPER so the small and big letters do not mess with the result
            string word1 = Console.ReadLine().ToUpper(); 
            string word2 = Console.ReadLine().ToUpper();

            if (word1 == word2)
            {
                Console.WriteLine("yes");
            } else
            {       
                Console.WriteLine("no");
	        }
        }
    }
}
