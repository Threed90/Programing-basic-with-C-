using System;

namespace _03.NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int helper = 0;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num-i; j++)
                {
                    Console.Write($"{i+j+1} ");
                    helper = i + j + 1;
                }

                for (int k = num -1; k >= num - i; k--)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
