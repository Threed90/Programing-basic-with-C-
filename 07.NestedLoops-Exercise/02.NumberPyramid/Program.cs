using System;

namespace _02.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; ; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    counter++;
                    Console.Write(counter + " ");
                    if(counter == num)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
