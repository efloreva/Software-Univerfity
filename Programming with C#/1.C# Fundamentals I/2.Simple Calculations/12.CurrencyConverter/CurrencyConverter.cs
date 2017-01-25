using System;

namespace _12.CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main()
        {
            //1 BGN courses USD 1.79549 / EUR 1.95583/ GBP 2.53405
            decimal inputValue = decimal.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine().ToUpper();
            string outputCurrency = Console.ReadLine().ToUpper();

            decimal inputValInBgn = 0; //input checks

            if (inputCurrency == "USD")
            {
                inputValInBgn = inputValue * 1.79549M; //put M for decimal nums
            }
            if (inputCurrency == "EUR")
            {
                inputValInBgn = inputValue * 1.95583M; //put M for decimal nums
            }

            if (inputCurrency == "GBP")
            {
                inputValInBgn = inputValue * 2.53405M; //put M for decimal nums
            }
            if (inputCurrency == "BGN")
            {
                inputValInBgn = inputValue;
            }

            // output checks

            decimal outputValue = 0;

            if (outputCurrency == "BGN")
            {
                Console.WriteLine("{0:F2} {1}", inputValInBgn, outputCurrency);
            }
            if (outputCurrency == "USD")
            {
                outputValue = inputValInBgn / 1.79549M;
                Console.WriteLine("{0:F2} {1}", outputValue, outputCurrency);

            }
            if (outputCurrency == "EUR")
            {
                outputValue = inputValInBgn / 1.95583M; //put M for decimal nums
                Console.WriteLine("{0:F2} {1}", outputValue, outputCurrency);
            }

            if (outputCurrency == "GBP")
            {
                outputValue = inputValInBgn / 2.53405M; //put M for decimal nums
                Console.WriteLine("{0:F2} {1}", outputValue, outputCurrency);
            }
        }
    }
}
