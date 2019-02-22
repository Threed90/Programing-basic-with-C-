using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();

            Console.WriteLine(GetArea(figure));
        }

        private static double GetArea(string typeOfFigure)
        {
            double area = 0;
            switch (typeOfFigure)
            {
                case "square":
                    double side = double.Parse(Console.ReadLine());
                    area = side * side;
                    break;
                case "triangle":
                    double baseSide = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    area = baseSide * height / 2;
                    break;
                case "rectangle":
                    side = double.Parse(Console.ReadLine());
                    double side2 = double.Parse(Console.ReadLine());
                    area = side * side2;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * radius * radius;
                    break;
            }
            return area;
        }
    }
}
