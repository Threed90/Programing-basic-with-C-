using System;

namespace _07.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i <= iterations; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum1 += num;
                }
                else
                {
                    sum2 += num;
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes{Environment.NewLine}Sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No{Environment.NewLine}Diff = {Math.Abs(sum1-sum2)}");
            }
        }
    }
}
