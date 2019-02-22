using System;

namespace _05.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int travelers = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stops; i++)
            {
                if(i%2==0)
                {
                    travelers -= int.Parse(Console.ReadLine());
                    travelers += int.Parse(Console.ReadLine());
                    travelers -= 2;
                }
                else
                {
                    travelers -= int.Parse(Console.ReadLine());
                    travelers += int.Parse(Console.ReadLine());
                    travelers += 2;
                }
            }
            Console.WriteLine($"The final number of passengers is : {travelers}");
        }
    }
}
