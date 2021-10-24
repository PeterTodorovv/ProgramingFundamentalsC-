using System;
using System.Linq;

namespace _02VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            VowelsCount();
        }

        static void VowelsCount()
        {
            string input = Console.ReadLine();
            char[] vowels = { 'a', 'e', 'u', 'i', 'o', 'A', 'E', 'U', 'I', 'O' };
            int totalVowels = 0;

            foreach(var letter in input)
            {
                if (vowels.Contains(letter))
                {
                    totalVowels++;
                }
            }
            Console.WriteLine(totalVowels);
        }
    }
}
