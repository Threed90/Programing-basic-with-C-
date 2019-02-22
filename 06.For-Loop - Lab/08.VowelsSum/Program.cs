using System;
using System.Collections.Generic;

namespace _08.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charValues = new Dictionary<char, int>();

            charValues.Add('a',1);
            charValues.Add('e',2);
            charValues.Add('i',3);
            charValues.Add('o',4);
            charValues.Add('u',5);

            char[] arr = Console.ReadLine().ToCharArray();

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(charValues.ContainsKey(arr[i]))
                sum += charValues[arr[i]];
            }

            Console.WriteLine(sum);
        }
    }
}
