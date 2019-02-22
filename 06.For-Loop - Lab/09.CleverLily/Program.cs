using System;

namespace _09.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washer = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double collectedMoney = 0;
            double money = 10;
            int toyCounter = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    collectedMoney += money;
                    money += 10;
                    collectedMoney--;
                }
                else
                {
                    toyCounter++;
                }
            }

            double total = collectedMoney + (toyCounter * toyPrice);

            if(washer <= total)
            {
                Console.WriteLine($"Yes! {total-washer:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washer-total:f2}");
            }
        }
    }
}
