using System;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double minX = Math.Min(x1, x2);
            double minY = Math.Min(y1, y2);
            double maxX = Math.Max(x1, x2);
            double maxY = Math.Max(y1, y2);

            double length = Math.Abs(maxX - minX);
            double width = Math.Abs(maxY - minY);

            double perimeter = 2 * length + 2 * width;
            double area = length * width;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);

        }
    }
}
