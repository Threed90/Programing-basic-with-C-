using System;

namespace _05.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterator = int.Parse(Console.ReadLine());

            int minNum = int.MaxValue;
            for (int i = 0; i < iterator; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (minNum > num)
                {
                    minNum = num;
                }
            }

            Console.WriteLine(minNum);
        }
    }
}
