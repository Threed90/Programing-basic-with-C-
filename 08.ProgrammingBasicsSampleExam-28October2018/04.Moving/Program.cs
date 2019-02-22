using System;

namespace _04.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int volume = width * length * height;

            while (true)
            {
                string cartons = Console.ReadLine();
                if(cartons=="Done")
                {
                    Console.WriteLine($"{Math.Abs(volume)} Cubic meters left.");
                    break;
                }

                volume -= int.Parse(cartons);

                if(volume<0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
                    break;
                }
            }
        }


    }
}
