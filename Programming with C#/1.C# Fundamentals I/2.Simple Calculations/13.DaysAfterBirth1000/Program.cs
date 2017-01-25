using System;
using System.Globalization;

namespace _13.DaysAfterBirth1000
{
    class DaysAfterBirth1000
    {
        /*Подсказки: потърсете информация за типа DateTime в C# и по-конкретно разгледайте методите ParseExact(str, format), AddDays(count) и 
         * ToString(format). */
        static void Main()
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime DOB = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", provider); //null works in place for provider, in that case above line is irrelevant
            DateTime outputDate = DOB.AddDays(999);
            Console.WriteLine("{0:dd-MM-yyyy}", outputDate);
        }
    }
}
