using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double currency = double.Parse(Console.ReadLine());
            string ExchangeCurrency = Console.ReadLine().ToLower();
            string ExchangeIN = Console.ReadLine().ToLower();

            if(ExchangeCurrency== "bgn")
            {
                if (ExchangeIN== "bgn")
                {
                    Console.WriteLine($"{currency:f2} BGN");
                }
                else if (ExchangeIN == "usd")
                {
                    Console.WriteLine($"{currency/ 1.79549:f2} USD");
                }
                else if (ExchangeIN == "eur")
                {
                    Console.WriteLine($"{currency / 1.95583:f2} EUR");
                }
                else if (ExchangeIN == "gbp")
                {
                    Console.WriteLine($"{currency / 2.53405:f2} GBP");
                }
            }
            else if(ExchangeCurrency == "usd")
            {
                if (ExchangeIN == "usd")
                {
                    Console.WriteLine($"{currency:f2} USD");
                }
                else if (ExchangeIN == "bgn")
                {
                    Console.WriteLine($"{currency * 1.79549:f2} BGN");
                }
                else if (ExchangeIN == "eur")
                {
                    Console.WriteLine($"{(currency * 1.79549) / 1.95583:f2} EUR");
                }
                else if (ExchangeIN == "gbp")
                {
                    Console.WriteLine($"{(currency * 1.79549) / 2.53405:f2} GBP");
                }
            }
            else if (ExchangeCurrency == "eur")
            {
                if (ExchangeIN == "eur")
                {
                    Console.WriteLine($"{currency:f2} EUR");
                }
                else if (ExchangeIN == "bgn")
                {
                    Console.WriteLine($"{(currency * 1.95583):f2} BGN");
                }
                else if (ExchangeIN == "usd")
                {
                    Console.WriteLine($"{(currency * 1.95583) / 1.79549:f2} USD");
                }
                else if (ExchangeIN == "gbp")
                {
                    Console.WriteLine($"{(currency * 1.95583) / 2.53405:f2} GBP");
                }
            }
            else if (ExchangeCurrency == "gbp")
            {
                if (ExchangeIN == "gbp")
                {
                    Console.WriteLine($"{currency:f2} GBP");
                }
                else if (ExchangeIN == "bgn")
                {
                    Console.WriteLine($"{(currency * 2.53405):f2} BGN");
                }
                else if (ExchangeIN == "usd")
                {
                    Console.WriteLine($"{(currency * 2.53405) / 1.79549:f2} USD");
                }
                else if (ExchangeIN == "gbp")
                {
                    Console.WriteLine($"{(currency * 2.53405) / 1.95583:f2} EUR");
                }
            }
        }
    }
}
