using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            List<double> oddNumber = new List<double>();
            List<double> evenNumber = new List<double>();

            for (int i = 1; i <= size; i++)
            {
                if(i%2 == 1)
                {
                    oddNumber.Add(double.Parse(Console.ReadLine()));
                }
                else
                {
                    evenNumber.Add(double.Parse(Console.ReadLine()));
                }
                
            }
            
            Console.WriteLine($"OddSum = {oddNumber.Sum()},");
            if(oddNumber.Sum() == 0)
            {
                Console.WriteLine($"OddMin = {"No"},");
                Console.WriteLine($"OddMax = {"No"},");
            }
            else
            {
                Console.WriteLine($"OddMin = {oddNumber.Min()},");
                Console.WriteLine($"OddMax = {oddNumber.Max()},");
            }
            Console.WriteLine($"EvenSum = {evenNumber.Sum()},");
            if (evenNumber.Sum() == 0)
            {
                Console.WriteLine($"EvenMin = {"No"},");
                Console.WriteLine($"EvenMax = {"No"}");
            }
            else
            {
                Console.WriteLine($"EvenMin = {evenNumber.Min()},");
                Console.WriteLine($"EvenMax = {evenNumber.Max()}");
            }
            
                 
            
        }
    }
}
