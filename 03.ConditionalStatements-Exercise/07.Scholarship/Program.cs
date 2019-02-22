using System;

namespace _07.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double revenues = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            PrintScholarship(revenues, grade, minSalary);
        }

        private static void PrintScholarship(double revenues, double grade, double minSalary)
        {
            double SocialscholarShip = Math.Floor(minSalary * 0.35);
            double scholarShipForExcellect = Math.Floor(25 * grade);
            bool isSocial = revenues < minSalary && grade > 4.5;
            bool isExcellect = grade >= 5.5;

            if (isSocial && isExcellect)
            {
                if (SocialscholarShip > scholarShipForExcellect)
                {
                    Console.WriteLine($"You get a Social scholarship {SocialscholarShip} BGN");
                }
                else if(scholarShipForExcellect>= SocialscholarShip)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scholarShipForExcellect} BGN");
                }
            }
            else if(isSocial && (!isExcellect))
            {
                Console.WriteLine($"You get a Social scholarship {SocialscholarShip} BGN");
            }
            else if ((!isSocial) && isExcellect)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarShipForExcellect} BGN");
            }
            else if ((!isSocial) && (!isExcellect))
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
