using System;

namespace _09.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char Operator = char.Parse(Console.ReadLine());
            
            PrintResult(N1, N2, Operator);

        }

        private static void PrintResult(int N1, int N2, char Operator)
        {
            if (Operator == '+')
            {
                if ((N1 + N2) % 2 == 0)
                {
                    Console.WriteLine($"{N1} {Operator} {N2} = {N1 + N2} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {Operator} {N2} = {N1 + N2} - odd");
                }
            }
            else if (Operator == '-')
            {
                if ((N1 - N2) % 2 == 0)
                {
                    Console.WriteLine($"{N1} {Operator} {N2} = {N1 - N2} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {Operator} {N2} = {N1 - N2} - odd");
                }
            }
            else if (Operator == '*')
            {
                if ((N1 * N2) % 2 == 0)
                {
                    Console.WriteLine($"{N1} {Operator} {N2} = {N1 * N2} - even"); 
                }
                else
                {
                    Console.WriteLine($"{N1} {Operator} {N2} = {N1 * N2} - odd");
                }
            }
            else if (Operator == '/')
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} {Operator} {N2} = {(double)N1 / N2:f2}");
                }
            }
            else if (Operator == '%')
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} {Operator} {N2} = {N1 % N2}");
                }
            }
        }
    }
}
