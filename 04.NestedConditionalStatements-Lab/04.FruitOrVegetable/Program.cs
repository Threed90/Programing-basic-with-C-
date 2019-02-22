using System;
using System.Linq;

namespace _04.FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string foodType = Console.ReadLine();

            PrintFoodType(foodType);
        }

        private static void PrintFoodType(string foodType)
        {
            string[] fruits = { "banana", "apple", "kiwi", "cherry", "lemon", "grapes" };
            string[] vegetables = { "tomato", "cucumber", "pepper", "carrot" };

            if (fruits.Contains(foodType))
            {
                Console.WriteLine("fruit");
            }
            else if (vegetables.Contains(foodType))
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
