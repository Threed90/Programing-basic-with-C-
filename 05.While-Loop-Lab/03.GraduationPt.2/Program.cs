using System;

namespace _03.GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double sum = 0;
            int counter = 0;
            int badGradeCounter = 0;

            while (counter<12)
            {
                double grade = double.Parse(Console.ReadLine());

                if(grade >= 4)
                {
                    sum += grade;
                    counter++;
                }
                else
                {
                    badGradeCounter++;
                    if(badGradeCounter == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {counter+1} grade");
                        return;
                    }
                }
            }

            Console.WriteLine($"{name} graduated. Average grade: {sum/counter:f2}");
        }
    }
}
