using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int cakeArea = width * length;

            while (true)
            {
                string cakePieces = Console.ReadLine();

                if(cakePieces == "STOP")
                {
                    Console.WriteLine($"{cakeArea} pieces are left.");
                    break;
                }
                cakeArea -= int.Parse(cakePieces);
                if (cakeArea < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeArea)} pieces more.");
                    break;
                }
            }
        }
    }
}
