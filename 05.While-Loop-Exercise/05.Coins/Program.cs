using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());

            int digitsValue = (int)(balance * 100);

            int[] coins = { 200, 100, 50, 20, 10, 5, 2, 1 };

            int counter = 0;
            int arrCounter = 0;

            while (digitsValue >0)
            {
                if(coins[arrCounter]<=digitsValue)
                {
                    digitsValue -= coins[arrCounter];
                    counter++;
                }
                else
                {
                    arrCounter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
