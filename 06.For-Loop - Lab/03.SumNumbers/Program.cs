using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterator = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < iterator; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
