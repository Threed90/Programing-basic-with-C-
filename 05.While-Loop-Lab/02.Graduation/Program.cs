using System;

namespace _02.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double sum = 0;

            double counter = 0;
            for (int i = 0; i < 12; i++)
            {
                sum ++;
            }
            while (counter < 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    sum += grade;
                    counter++;
                }
            }
            
            double average = sum / counter;

            Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            Console.WriteLine(counter);
        }
    }
}
