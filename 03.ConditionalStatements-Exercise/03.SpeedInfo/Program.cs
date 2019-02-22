using System;

namespace _03.SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            Console.WriteLine(GetSpeedInfo(speed));
        }

        private static string GetSpeedInfo(double speed)
        {
            string speedInfo = null;

            if (speed <= 10)
            {
                speedInfo = "slow";
            }
            else if(speed>10 && speed <= 50)
            {
                speedInfo = "average";
            }
            else if (speed>50 && speed <= 150)
            {
                speedInfo = "fast";
            }
            else if(speed > 150 && speed <= 1000)
            {
                speedInfo = "ultra fast";
            }
            else if (speed > 1000)
            {
                speedInfo = "extremely fast";
            }

            return speedInfo;
        }
    }
}
