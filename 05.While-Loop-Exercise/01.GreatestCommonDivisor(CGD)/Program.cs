using System;

namespace _01.GreatestCommonDivisor_CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int minNum = Math.Min(num1, num2);
            int maxNum = Math.Max(num1, num2);

            int left = 1;

            while (left>0)
            {
                left = maxNum % minNum;
                maxNum = minNum;
                minNum = left;
            }

            Console.WriteLine(maxNum);
        }
    }
}
