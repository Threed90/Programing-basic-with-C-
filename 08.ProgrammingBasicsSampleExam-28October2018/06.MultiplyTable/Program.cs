using System;
using System.Linq;

namespace _06.MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().ToCharArray().Select(x => (int)char.GetNumericValue(x)).ToArray();

            foreach (int item in nums)
            {
                if(item<=0)
                {
                    return;
                }
            }

            for (int i = 1; i <= nums[2]; i++)
            {
                for (int j = 1; j <= nums[1]; j++)
                {
                    for (int k = 1; k <= nums[0]; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i*j*k};");
                    }
                }
            }
        }
    }
}
