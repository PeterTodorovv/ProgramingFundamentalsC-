using System;
using System.Linq;

namespace _07EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numebrs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numebrs2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int unidenticalIndex = -1;
            int sum = 0;
            for (int i = 0; i < numebrs.Length; i++)
            {
                if (numebrs[i] != numebrs2[i])
                {
                    unidenticalIndex = i;
                    break;
                }
                sum += numebrs[i];
            }
            if (unidenticalIndex == -1) Console.WriteLine($"Arrays are identical. Sum: {sum}");
            else Console.WriteLine($"Arrays are not identical. Found difference at {unidenticalIndex} index");
        }
    }
}
