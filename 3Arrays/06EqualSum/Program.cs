using System;
using System.Linq;

namespace _06EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for(int index = 0; index < i; index++)
                {
                    leftSum += numbers[index];
                }
                for(int rightSide = i+1; rightSide < numbers.Length; rightSide++)
                {
                    rightSum += numbers[rightSide];
                }
                if(leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
