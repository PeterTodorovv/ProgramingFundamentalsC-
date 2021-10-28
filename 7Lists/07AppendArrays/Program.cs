using System;
using System.Collections.Generic;
using System.Linq;

namespace _07AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|").ToArray();
            int[] finalArray ={ };

            for(int i = input.Length - 1; i>=0; i--)
            {
                int[] array = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                finalArray = finalArray.Concat(array).ToArray();
            }


            Console.WriteLine(string.Join(" ", finalArray));
        }
    }
}
