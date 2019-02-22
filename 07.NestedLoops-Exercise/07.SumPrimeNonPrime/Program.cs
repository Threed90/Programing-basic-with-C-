using System;

namespace _07.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            long sumPrime = 0;
            long sumNotPrime = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }

                long num = long.Parse(input);
                if(num<0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                if ((num % 2 == 0 || num % 3 == 0 || num % 5 == 0 || num % 7 == 0) && num != 2 && num != 3 && num != 5 && num != 7)
                { 
                    sumNotPrime += num;
                }
                else if(num==1)
                {
                    sumNotPrime += num;
                }
                else
                {
                    sumPrime += num;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNotPrime}");
        }
    }
}
