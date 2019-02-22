using System;

namespace _07.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabNumber = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < tabNumber; i++)
            {
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary -= 150;
                }
                else if (website == "Instagram")
                {
                    salary -= 100;
                }
                else if (website == "Reddit")
                {
                    salary -= 50;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }

            Console.WriteLine(salary);
        }
    }
}
