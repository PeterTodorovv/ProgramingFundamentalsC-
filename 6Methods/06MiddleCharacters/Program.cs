using System;

namespace _06MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            GetMid(input);
        }

        static void GetMid(string input)
        {
            if(input.Length % 2 == 0)
            {
                Console.WriteLine(input[input.Length/2-1].ToString() + input[input.Length / 2].ToString());
            }
            else
            {
                char symbol = input[input.Length / 2];
                Console.WriteLine(symbol);
            }
        }
    }
}
