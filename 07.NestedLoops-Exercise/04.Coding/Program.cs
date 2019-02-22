using System;
using System.Linq;

namespace _04.Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Select(x => (int)char.GetNumericValue(x)).ToArray();


            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] == 0)
                {
                    Console.WriteLine("ZERO");
                }
                else
                {
                    Console.WriteLine(new string((char)(nums[i] + 33), nums[i]));
                }
            }
        }
    }
}
