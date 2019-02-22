using System;

namespace _02.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());

            int counter = 0;

            while (counter<capacity)
            {
                string currentBook = Console.ReadLine();
                counter++;

                if (currentBook == book)
                {
                    Console.WriteLine($"You checked {counter-1} books and found it.");
                    return;
                }

            }

            Console.WriteLine($"The book you search is not here!{Environment.NewLine}You checked {counter} books.");
        }
    }
}
