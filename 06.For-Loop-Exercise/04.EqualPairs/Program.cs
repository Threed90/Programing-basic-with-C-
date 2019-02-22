using System;

namespace _04.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());

            int sum = 0;
            int diff = 0;

            for (int i = 0; i < iterations; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if(i>0 && sum != num1 + num2)
                {
                    if(diff< Math.Abs(sum - (num1 + num2)))
                    {
                        diff = Math.Abs(sum - (num1 + num2));
                    }
                }
                sum = num1 + num2;
            }

            if(diff == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={diff}");
            }
        }
    }
}
