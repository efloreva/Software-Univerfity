using System;

namespace _10.AnimalType
{
    class AnimalType
    {
        static void Main()
        {
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "crocodile": Console.WriteLine("reptile"); break;
                case "tortoise": Console.WriteLine("reptile"); break;
                case "snake": Console.WriteLine("reptile"); break;
                case "dog": Console.WriteLine("mammal"); break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
