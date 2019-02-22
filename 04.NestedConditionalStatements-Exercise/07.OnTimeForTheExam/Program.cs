using System;

namespace _07.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());
            
            int leftedTime = GetTime(examHour, examMin, arrivalHour, arrivalMin);

            PrintTime(leftedTime);
        }

        private static void PrintTime(int leftedTime)
        {
            if (leftedTime >= 0 && leftedTime <= 30)
            {
                Console.WriteLine("On time");
            }
            else if (leftedTime > 30)
            {
                Console.WriteLine("Early");
            }
            else
            {
                Console.WriteLine("Late");
            }

            int hour, min;
            if (leftedTime >= 0 && leftedTime <= 59)
            {
                Console.WriteLine($"{leftedTime} minutes before the start");
            }
            else if (leftedTime > 59)
            {
                hour = leftedTime / 60;
                min = leftedTime % 60;
                Console.WriteLine($"{hour}:{min:d2} hours before the start");
            }
            else if (leftedTime < (-59))
            {
                hour = Math.Abs(leftedTime) / 60;
                min = Math.Abs(leftedTime) % 60;
                Console.WriteLine($"{hour}:{min:d2} hours after the start");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(leftedTime)} minutes after the start");
            }
        }

        private static int GetTime(int examHour, int examMin, int arrivalHour, int arrivalMin)
        {
            int examTime = examHour * 60 + examMin;
            int arrivalTime = arrivalHour * 60 + arrivalMin;

            int leftedTime = examTime - arrivalTime;

            return leftedTime;
        }
    }
}
