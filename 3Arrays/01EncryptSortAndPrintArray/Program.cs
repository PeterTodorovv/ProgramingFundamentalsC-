using System;
using System.Linq;

namespace _01EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            int[] sortedArray = new int[numberOfStrings];

            for(int i = 0; i < numberOfStrings; i++)
            {
                string line = Console.ReadLine();
                int lineSum = 0;
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'}; 
                foreach(var letter in line)
                {
                    if (vowels.Contains(letter)){
                        lineSum += letter * line.Length;
                    }
                    else
                    {
                        lineSum += letter / line.Length;
                    }
                }
                sortedArray[i] = lineSum;
            }
            Array.Sort(sortedArray);
            foreach (var number in sortedArray) Console.WriteLine(number);
        }
    }
}
