using System;

namespace _08.Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.Parse(Console.ReadLine());

            int num = 1;

            while (num<=maxNum)
            {
                Console.WriteLine(num);

                num = num * 2 + 1;
                
            }
        }
    }
}
