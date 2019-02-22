using System;

namespace _01.PointOnRectangleBorder
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

            PrintResult(x1, y1, x2, y2, x, y);
        }

        private static void PrintResult(double x1, double y1, double x2, double y2, double x, double y)
        {
            if(((x==x1 || x==x2) && y>=y1 && y<=y2) || ((y==y1 || y==y2) && x>=x1 && x<=x2))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
