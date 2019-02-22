using System;
using System.Linq;

namespace _10.PartyInvitation
{
    class Program
    {
        static void Main(string[] args)
        {
            double valid = 0;
            double invalid = 0;
            bool isInvalid = true;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Statistic")
                {
                    break;
                }

                for (int i = 0; i < input.Length; i++)
                {
                    if (!char.IsLetter(input[i]))
                    {
                        Console.WriteLine("Invalid name!");
                        invalid++;
                        isInvalid = false;
                        break;
                    }
                }
                if (isInvalid)
                {
                    valid++;
                    Console.WriteLine(input.First().ToString().ToUpper() + input.Substring(1, input.Length - 1).ToLower());
                }
                isInvalid = true;
            }

            Console.WriteLine($"Valid names are {(valid / (valid + invalid)) * 100:f2}% from {valid + invalid} names.");
            Console.WriteLine($"Invalid names are {(invalid / (valid + invalid)) * 100:f2}% from {valid + invalid} names.");
        }
    }
}
