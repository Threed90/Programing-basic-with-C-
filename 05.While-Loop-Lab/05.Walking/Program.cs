using System;

namespace _05.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            while (sum<10000)
            {
                string steps = Console.ReadLine();

                if(steps == "Going home")
                {
                    sum += int.Parse(Console.ReadLine());

                    if(sum>=10000)
                    {
                        break;
                    }

                    Console.WriteLine($"{10000-sum} more steps to reach goal.");
                    return;
                }

                sum += int.Parse(steps);
            }

            Console.WriteLine("Goal reached! Good job!");
        }
    }
}
