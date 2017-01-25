using System;
namespace _09.SumDigitsOfNum
{ /*в цикъл докато не стигнете до 0 сумирайте последната цифра на числото (num % 10) и го разделяйте след това на 10 (така изтривате последната
    му цифра). */
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = n; i > 0; i--)
            {
                sum += (i % 10); //turn i not n
                i = i / 10 + 1;
            }
            Console.WriteLine(sum);
        }
    }
}