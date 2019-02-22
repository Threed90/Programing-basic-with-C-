using System;

namespace _01.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());

            char gender = char.Parse(Console.ReadLine());

            PrintSalutation(age, gender);
        }

        private static void PrintSalutation(double age, char gender)
        {
            if (gender == 'm')
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
            else if (gender == 'f')
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }

        }
    }
}
