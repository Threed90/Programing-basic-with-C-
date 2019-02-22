using System;

namespace _01.NumbersNto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = num; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
