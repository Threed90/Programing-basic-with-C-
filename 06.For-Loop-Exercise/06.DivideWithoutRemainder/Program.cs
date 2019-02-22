using System;
using System.Collections.Generic;

namespace _06.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> numsBook = new Dictionary<string, double[]>();

            numsBook.Add("to2", new double[2]);
            numsBook.Add("to3", new double[2]);
            numsBook.Add("to4", new double[2]);

            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    numsBook["to2"][0]++;
                }
                if(num%3==0)
                {
                    numsBook["to3"][0]++;
                }
                if(num%4==0)
                {
                    numsBook["to4"][0]++;
                }
            }

            numsBook["to2"][1] = (numsBook["to2"][0] / iterations) * 100;
            numsBook["to3"][1] = (numsBook["to3"][0] / iterations) * 100;
            numsBook["to4"][1] = (numsBook["to4"][0] / iterations) * 100;

            foreach (KeyValuePair<string, double[]> item in numsBook)
            {
                Console.WriteLine($"{item.Value[1]:f2}%");
            }

        }
    }
}
