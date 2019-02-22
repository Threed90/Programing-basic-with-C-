using System;

namespace _07.NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameholder = "";
            int bigestSum = int.MinValue;

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "STOP")
                {
                    break;
                }
                int sum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    sum += (int)name[i];
                }
                if (bigestSum < sum)
                {
                    bigestSum = sum;
                    nameholder = name;
                }
            }
            Console.WriteLine($"Winner is {nameholder} - {bigestSum}!");
        }
    }
}
