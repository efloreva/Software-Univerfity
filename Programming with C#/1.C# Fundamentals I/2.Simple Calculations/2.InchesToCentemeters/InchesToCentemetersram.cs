﻿using System;

namespace InchesToCentemeters
{
    class InchesToCentemeters
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;
            Console.Write("Centemeters = ");
            Console.WriteLine(centimeters);
        }
    }
}
