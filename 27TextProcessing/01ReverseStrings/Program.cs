using System;
using System.Text;

namespace _01ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while(input != "end")
            {
                StringBuilder reversedText = new StringBuilder();

                for(int i = input.Length - 1; i >= 0; i--)
                {
                    reversedText.Append(input[i]);
                }

                Console.WriteLine($"{input} = {reversedText}");
                input = Console.ReadLine();
            }
        }
    }
}
