using System;
using System.Linq;

namespace _04.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            while(input != "END")
            {
                int number = int.Parse(input);

                if (number < minNumber)
                {
                    minNumber = number;
                }
                if(number>maxNumber)
                {
                    maxNumber = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Max number: {maxNumber}{Environment.NewLine}Min number: {minNumber}");
        }
    }
}
