using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            string fromUnits = Console.ReadLine().ToLower();
            string toUnits = Console.ReadLine().ToLower();

            Console.WriteLine($"{GetConverted(distance, fromUnits, toUnits):f8}");
        }

        private static double GetConverted(double distance, string from, string to)
        {
            double convertedMetrics = 0;

            switch (from)
            {
                case "m":
                    convertedMetrics = distance;
                    break;
                case "mm":
                    convertedMetrics = distance / 1000;
                    break;
                case "cm":
                    convertedMetrics = distance / 100;
                    break;
                case "mi":
                    convertedMetrics = distance / 0.000621371192;
                    break;
                case "in":
                    convertedMetrics = distance / 39.3700787;
                    break;
                case "km":
                    convertedMetrics = distance / 0.001;
                    break;
                case "ft":
                    convertedMetrics = distance / 3.2808399;
                    break;
                case "yd":
                    convertedMetrics = distance / 1.0936133;
                    break;
            }

            switch (to)
            {
                case "m":
                    convertedMetrics = convertedMetrics*1;
                    break;
                case "mm":
                    convertedMetrics = convertedMetrics * 1000;
                    break;
                case "cm":
                    convertedMetrics = convertedMetrics * 100;
                    break;
                case "mi":
                    convertedMetrics = convertedMetrics * 0.000621371192;
                    break;
                case "in":
                    convertedMetrics = convertedMetrics * 39.3700787;
                    break;
                case "km":
                    convertedMetrics = convertedMetrics * 0.001;
                    break;
                case "ft":
                    convertedMetrics = convertedMetrics * 3.2808399;
                    break;
                case "yd":
                    convertedMetrics = convertedMetrics * 1.0936133;
                    break;
            }

            return convertedMetrics;
        }
    }
}
