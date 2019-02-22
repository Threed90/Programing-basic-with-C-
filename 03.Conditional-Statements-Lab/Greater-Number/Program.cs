using System;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int max = Math.Max(num1, num2);

            Console.WriteLine(max);
        }
    }
}
