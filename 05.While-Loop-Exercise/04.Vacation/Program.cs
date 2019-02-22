using System;

namespace _04.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            double cash = double.Parse(Console.ReadLine());

            int dayCounter = 0;
            int spendCounter = 0;


            while (true)
            {
                string action = Console.ReadLine();
                double value = double.Parse(Console.ReadLine());

                dayCounter++;

                if (action == "spend")
                {
                    spendCounter++;
                    cash -= value;
                    if (spendCounter == 5)
                    {
                        Console.WriteLine($"You can't save the money.{Environment.NewLine}{dayCounter}");
                        break;
                    }
                    if (cash < 0)
                    {
                        cash = 0;
                    }
                }
                else if(action == "save")
                {
                    cash += value;
                    spendCounter = 0;
                    if (cash >= excursionPrice)
                    {
                        Console.WriteLine($"You saved the money for {dayCounter} days.");
                        break;
                    }
                }
            }
        }
    }
}
