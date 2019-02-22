using System;
using System.Linq;

namespace _05.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            if (start >= 100000 && end <= 300000)
            {
                for (int i = start; i <= end; i++)
                {
                    int[] digits = new int[6];
                    int holder = i;
                    for (int j = 0; j < 6; j++)
                    {
                        digits[j] = holder % 10;
                        holder /= 10;
                    }
                    //char[] omg = Convert.ToString(i).ToCharArray();
                    //int sum1 = omg.Where((x, y) => y % 2 == 0).Select(x => (int)char.GetNumericValue(x)).ToArray().Sum();
                    //int sum2 = omg.Where((x, y) => y % 2 != 0).Select(x => (int)char.GetNumericValue(x)).ToArray().Sum();

                    if (digits[0] + digits[2] + digits[4] == digits[1] + digits[3] + digits[5])
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
