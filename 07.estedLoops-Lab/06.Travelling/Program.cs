using System;

namespace _06.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                
                
                if (destination == "End")
                {
                    break;
                }
                double budget = double.Parse(Console.ReadLine());
                
                for (int i = 0; i < (int)(budget * 100);)
                {
                    double savedMoney = double.Parse(Console.ReadLine());

                    i += ((int)(savedMoney) * 100);
                }

                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
