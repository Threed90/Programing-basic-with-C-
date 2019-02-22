using System;

namespace _06.EqualSumsLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            if(startNum<10000 && endNum>99999)
            {
                return;
            }

            for (int i = startNum; i <= endNum; i++)
            {
                int[] digits = new int[5];
                int holder = i;
                for (int j = 0; j < 5; j++)
                {
                    digits[j] = holder % 10;
                    holder /= 10;
                }

                if(digits[0]+digits[1] == digits[3]+digits[4])
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    int sum1 = digits[0] + digits[1];
                    int sum2 = digits[3] + digits[4];
                    int min = Math.Min(sum1, sum2);
                    int max= Math.Max(sum1, sum2);
                    if (min+digits[2] == max)
                    {
                        Console.Write($"{i} ");
                    }
                    
                }
            }
        }
    }
}
