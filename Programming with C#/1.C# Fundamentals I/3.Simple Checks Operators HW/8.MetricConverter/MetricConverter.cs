using System;

namespace _12.MetricConverter
{
    class MetricConverter
    {
        static void Main()
        {
            //1 BGN	USD courses 1.79549 / EUR 1.95583/ GBP 2.53405
            double inputValue = double.Parse(Console.ReadLine());
            string inputMetrics = Console.ReadLine();
            string outputMetrics = Console.ReadLine();

            double inputValInMeters = 0; //input checks
            if (inputMetrics == "mm")
            {
                inputValInMeters = inputValue / 1000; 
            }
            if (inputMetrics == "cm")
            {
                inputValInMeters = inputValue / 100; 
            }

            if (inputMetrics == "mi")
            {
                inputValInMeters = inputValue / 0.000621371192; 
            }
            if (inputMetrics == "in")
            {
                inputValInMeters = inputValue / 39.3700787; 
            } 
            if (inputMetrics == "km")
            {
                inputValInMeters = inputValue / 0.001; 
            } 
            if (inputMetrics == "ft")
            {
                inputValInMeters = inputValue / 3.2808399; 
            } 
            if (inputMetrics == "yd")
            {
                inputValInMeters = inputValue / 1.0936133; 
            }
            if (inputMetrics == "m")
            {
                inputValInMeters = inputValue;
            }

            // output checks

            double outputValue = 0;

            if (outputMetrics == "m")
            {
                Console.WriteLine("{0} {1}", inputValInMeters, outputMetrics);
            }
            if (outputMetrics == "mm")
            {
                outputValue = inputValInMeters * 1000;
                Console.WriteLine("{0} {1}", outputValue, outputMetrics);
            }
            if (outputMetrics == "cm")
            {
                outputValue = inputValInMeters * 100; 
                Console.WriteLine("{0} {1}", outputValue, outputMetrics);
            }

            if (outputMetrics == "mi")
            {
                outputValue = inputValInMeters * 0.000621371192; 
                Console.WriteLine("{0} {1}", outputValue, outputMetrics);
            }
            if (outputMetrics == "in")
            {
                outputValue = inputValInMeters * 39.3700787; 
                Console.WriteLine("{0} {1}", outputValue, outputMetrics);
            }
            if (outputMetrics == "km")
            {
                outputValue = inputValInMeters * 0.001;
                Console.WriteLine("{0} {1}", outputValue, outputMetrics);
            }
            if (outputMetrics == "ft")
            {
                outputValue = inputValInMeters * 3.2808399; 
                Console.WriteLine("{0} {1}", outputValue, outputMetrics);
            }
            if (outputMetrics == "yd")
            {
                outputValue = inputValInMeters * 1.0936133; 
                Console.WriteLine("{0} {1}", outputValue, outputMetrics);
            }

        }
    }
}
