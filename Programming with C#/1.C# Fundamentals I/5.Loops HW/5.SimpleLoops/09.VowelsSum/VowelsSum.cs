using System;
namespace _09.VowelsSum
{
    class VowelsSum
    {
        static void Main()
        {
            string word = Console.ReadLine().ToLower();

            int vowelSum = 0;

            for (int i = 0; i < word.Length; i++) //till end of word, not -1
            {
                char currentSymbol = word[i];
                switch (currentSymbol)
                {
                    case 'a': vowelSum += 1; break;
                    case 'e': vowelSum += 2; break;
                    case 'i': vowelSum += 3; break;
                    case 'o': vowelSum += 4; break;
                    case 'u': vowelSum += 5; break;
                }
            }
            Console.WriteLine(vowelSum);
        }
    }
}
