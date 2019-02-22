using System;

namespace _03.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGradeLimit = int.Parse(Console.ReadLine());
            int badGradeConst = badGradeLimit;

            int counter = 0;
            int sum = 0;
            string lastTask = "";

            while (badGradeConst !=0)
            {
                string nameOfTask = Console.ReadLine();

                if(nameOfTask == "Enough")
                {
                    Console.WriteLine($"Average score: {(double)sum/counter:f2}" +
                        $"{Environment.NewLine}Number of problems: {counter}" +
                        $"{Environment.NewLine}Last problem: {lastTask}");
                    return;
                }
                int grade = int.Parse(Console.ReadLine());
                
                counter++;
                sum += grade;
                lastTask = nameOfTask;
                if (grade <= 4)
                {
                    badGradeConst--;
                }
            }

            Console.WriteLine($"You need a break, {badGradeLimit} poor grades.");
        }
    }
}
