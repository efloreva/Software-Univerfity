using System;

namespace _9.PasswordGuess
{
    class PasswordGuess
    {
        static void Main()
        {
            string inputPassword = Console.ReadLine();
            if (inputPassword == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
