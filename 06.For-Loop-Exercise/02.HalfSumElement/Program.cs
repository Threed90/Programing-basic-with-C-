using System;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;

            for (int i = 0; i < iterations; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (maxNum < number)
                {
                    maxNum = number;
                }
                
            }
            if (sum - maxNum == maxNum)
            {
                Console.WriteLine($"Yes{Environment.NewLine}Sum = {maxNum}");
                return;
            }
            Console.WriteLine($"No{Environment.NewLine}Diff = {Math.Abs((sum-maxNum)-maxNum)}");
        }
    }
}
