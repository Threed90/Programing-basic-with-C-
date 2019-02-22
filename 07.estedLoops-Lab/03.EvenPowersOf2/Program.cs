using System;

namespace _03.EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0, j = 1; i <= num; i+=2, j*=4)
            {
                Console.WriteLine(j);
            }
        }
    }
}
