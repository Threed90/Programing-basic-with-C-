using System;

namespace _12.StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int letter = int.Parse(Console.ReadLine());

            for (int first = 1; first <= num; first++)
            {
                for (int second = 1; second <= num; second++)
                {
                    for (int third = 97; third < 97+letter; third++)
                    {
                        for (int four = 97; four < 97+letter; four++)
                        {
                            for (int five = 1; five <= num; five++)
                            {
                                if(five>first && five > second)
                                {
                                    Console.Write($"{first}{second}{(char)third}{(char)four}{five} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
