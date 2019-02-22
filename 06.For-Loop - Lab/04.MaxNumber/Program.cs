using System;

namespace _04.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterator = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            for (int i = 0; i < iterator; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (maxNum < num)
                {
                    maxNum = num;
                }
            }

            Console.WriteLine(maxNum);
        }
    }
}
