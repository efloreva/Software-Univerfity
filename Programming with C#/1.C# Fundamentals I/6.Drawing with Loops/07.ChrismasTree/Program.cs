using System;
namespace _07.ChrismasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++) // with =
            {
                //((n - i) * free space) + ( i * asterix) + | + ( i * asterix ) + ((n - i) * free space)
                string emptySpace = new string(' ', n - i);
                string asterisk = new string('*', i);

                Console.WriteLine(emptySpace + asterisk + " | " + asterisk + emptySpace);
                                                   // mind the spaces
    /*            if (n == 1) 
                {
                    Console.WriteLine("  |");
                    Console.Write("* ");
                    Console.Write("| ");
                    Console.WriteLine("*");
                } */
            }
        }
    }
}
