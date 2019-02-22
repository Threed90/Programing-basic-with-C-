using System;

namespace _05.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterator, number;

            iterator = int.Parse(Console.ReadLine());

            int till200 = 0, till400 = 0, till600 = 0, till800 = 0, over = 0;


            for (int i = 0; i < iterator; i++)
            {
                number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    till200++;
                }
                else if (number >= 200 && number < 400)
                {
                    till400++;
                }
                else if (number >= 400 && number < 600)
                {
                    till600++;
                }
                else if (number >= 600 && number < 800)
                {
                    till800++;
                }
                else
                {
                    over++;
                }
            }



            Console.WriteLine($"{((double)till200 / iterator) * 100:f2}%");      
            Console.WriteLine($"{((double)till400 / iterator) * 100:f2}%");      
            Console.WriteLine($"{((double)till600 / iterator) * 100:f2}%");      
            Console.WriteLine($"{((double)till800 / iterator) * 100:f2}%");
            Console.WriteLine($"{((double)over / iterator) * 100:f2}%"); 
        }
    }
}
