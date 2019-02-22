using System;
using System.Collections.Generic;

namespace _03.SushiTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> sushi = new Dictionary<string, Dictionary<string, double>>();

            sushi.Add("Sushi Zone", new Dictionary<string, double>());
            sushi.Add("Sushi Time", new Dictionary<string, double>());
            sushi.Add("Sushi Bar", new Dictionary<string, double>());
            sushi.Add("Asian Pub", new Dictionary<string, double>());

            sushi["Sushi Zone"]["sashimi"] = 4.99;
            sushi["Sushi Zone"]["maki"] = 5.29;
            sushi["Sushi Zone"]["uramaki"] = 5.99;
            sushi["Sushi Zone"]["temaki"] = 4.29;
            
            sushi["Sushi Time"]["sashimi"] = 5.49;
            sushi["Sushi Time"]["maki"] = 4.69;
            sushi["Sushi Time"]["uramaki"] = 4.49;
            sushi["Sushi Time"]["temaki"] = 5.19;
            
            sushi["Sushi Bar"]["sashimi"] = 5.25;
            sushi["Sushi Bar"]["maki"] = 5.55;
            sushi["Sushi Bar"]["uramaki"] = 6.25;
            sushi["Sushi Bar"]["temaki"] = 4.75;
            
            sushi["Asian Pub"]["sashimi"] = 4.50;
            sushi["Asian Pub"]["maki"] = 4.80;
            sushi["Asian Pub"]["uramaki"] = 5.50;
            sushi["Asian Pub"]["temaki"] = 5.50;

            string sushiType = Console.ReadLine();
            string restaurantName = Console.ReadLine();
            int numberOfPorcine = int.Parse(Console.ReadLine());
            char order = char.Parse(Console.ReadLine());
            if(!sushi.ContainsKey(restaurantName))
            {
                Console.WriteLine($"{restaurantName} is invalid restaurant!");
                return;
            }

            double price = sushi[restaurantName][sushiType] * numberOfPorcine;

            if(order=='Y')
            {
                price += (price * 0.2);
            }

            Console.WriteLine($"Total price: {Math.Ceiling(price)} lv.");
        }
    }
}
