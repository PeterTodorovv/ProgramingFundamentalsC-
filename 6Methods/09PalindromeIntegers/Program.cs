using System;

namespace _09PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while(command != "END")
            {
                PalindromeChecker(command);
                command = Console.ReadLine();
            }
                
        }

        private static void PalindromeChecker(string command)
        {
            int number = int.Parse(command);
            char[] reversedNumberArray = command.ToCharArray();
            Array.Reverse(reversedNumberArray);
            int reversedNumber = int.Parse(String.Join("", reversedNumberArray));
            if (number == reversedNumber)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
