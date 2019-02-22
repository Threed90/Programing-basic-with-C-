using System;

namespace _01.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int first = a; first <= b; first++)
            {
                for (int second = a; second <= b; second++)
                {
                    for (int third = c; third <= d; third++)
                    {
                        for (int four = c; four <= d; four++)
                        {
                            if(first+four == second + third && first!=second && third!=four)
                            {
                                Console.WriteLine($"{first}{second}");
                                Console.WriteLine($"{third}{four}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
