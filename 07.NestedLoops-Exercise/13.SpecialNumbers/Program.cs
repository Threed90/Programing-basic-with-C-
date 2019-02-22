using System;

namespace _13.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int first = 1; first < 10; first++)
            {
                for (int second = 1; second < 10; second++)
                {
                    for (int third = 1; third < 10; third++)
                    {
                        for (int four = 1; four < 10; four++)
                        {
                            if(num%first==0 && num%second==0 && num%third==0 && num%four==0)
                            {
                                Console.Write($"{first}{second}{third}{four} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
