using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> results = new Dictionary<string, double[]>();

            int jury = int.Parse(Console.ReadLine());

            while (true)
            {
                string themes = Console.ReadLine();
                if(themes=="Finish")
                {
                    break;
                }

                results.Add(themes, new double[jury]);

                for (int i = 0; i < jury; i++)
                {
                    results[themes][i] = double.Parse(Console.ReadLine());
                }
            }

            foreach (KeyValuePair<string, double[]> item in results)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Average():f2}.");
            }

            Console.WriteLine($"Student's final assessment is {results.Values.Average(x => x.Average()):f2}.");
        }
    }
}
