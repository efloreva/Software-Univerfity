using System;
namespace _08.Sunglasses
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string asterisks = new string('*', 2 * n);
            string spaces = new string(' ', n);
            string slashes = new string('/', 2 * n - 2);
            string lines = new string('|', n);

            for (int i = 0; i < n; i++) 
            {
                //middle part
                //o	звездичка; 2*n-2 наклонени черти; звездичка; n интервала; звездичка; 2*n-2 наклонени черти; звездичка
                if (i == 0 || i == n - 1) //start and end
                {
                    Console.WriteLine(asterisks + spaces + asterisks);
                }
                else
                    if (i == (n - 1) / 2) //line in the middle line n-1/2
                    { // o	когато редът е (n-1) / 2 - 1, печатайте n вертикални черти вместо n интервала
                        Console.WriteLine("*" + slashes + "*" + lines + "*" + slashes + "*");
                    }
                    else
                        Console.WriteLine("*" + slashes + "*" + spaces + "*" + slashes + "*");
            }
        }
    }
}
