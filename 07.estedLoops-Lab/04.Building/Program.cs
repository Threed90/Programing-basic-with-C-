using System;

namespace _04.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor
                 = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            
            for (int i = floor; i > 0; i--)
            {
                if (i % 2 == 1 || i == floor)
                {
                    for (int j = 0; j < rooms; j++)
                    {
                        if (i == floor)
                        {
                            Console.Write($"L{i}{j} ");
                        }
                        else
                        {
                            Console.Write($"A{i}{j} ");
                        }

                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < rooms; j++)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
