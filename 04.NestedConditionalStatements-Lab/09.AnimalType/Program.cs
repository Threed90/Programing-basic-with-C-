using System;
using System.Linq;

namespace _09.AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine().ToLower();

            string[] reptile = new string[] { "crocodile", "tortoise", "snake" };

            if (animal == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (reptile.Contains(animal))
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
