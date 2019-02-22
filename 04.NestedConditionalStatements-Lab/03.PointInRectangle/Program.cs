using System;

namespace _03.PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            string pointPosition = GetPointPosition(x1, y1, x2, y2, x, y);

            Console.WriteLine(pointPosition);
        }

        private static string GetPointPosition(double x1, double y1, double x2, double y2, double x, double y)
        {
            double minX = Math.Min(x1, x2);
            double maxX = Math.Max(x1, x2);
            double minY = Math.Min(y1, y2);
            double maxY = Math.Max(y1, y2);

            string position = "";

            if (minX <= x && maxX >= x && minY <= y && maxY >= y)
            {
                position = "Inside";
            }
            else
            {
                position = "Outside";
            }

            return position;
        }
    }
}
