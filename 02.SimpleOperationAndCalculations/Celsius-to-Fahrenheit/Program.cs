using System;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double faren = celsius * 1.8 + 32;
            Console.WriteLine(faren);
        }
    }
}
