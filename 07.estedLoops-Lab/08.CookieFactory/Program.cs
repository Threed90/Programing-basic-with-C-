using System;

namespace _08.CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batch = int.Parse(Console.ReadLine());

            bool ingredient1 = false;
            bool ingredient2 = false;
            bool ingredient3 = false;
           
            int num = 1;
            while (batch > 0)
            {
                string ingredient = Console.ReadLine();

                if (ingredient == "flour")
                {
                    ingredient1 = true;
                }
                else if (ingredient == "eggs")
                {
                    ingredient2 = true;
                }
                else if (ingredient == "sugar")
                {
                    ingredient3 = true;
                }

                if (ingredient == "Bake!")
                {
                    if (ingredient1 && ingredient2 && ingredient3)
                    {
                        Console.WriteLine($"Baking batch number {num++}...");
                        batch--;
                        ingredient1 = false;
                        ingredient2 = false;
                        ingredient3 = false;
                    }
                    else
                    {
                        Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    }
                }
            }
        }
    }
}
