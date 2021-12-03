using System;
using System.Text;

namespace _04CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder cipher = new StringBuilder();

            for(int i = 0; i < input.Length; i++)
            {
                char character = (char)(input[i] + 3);
                cipher.Append(character);
            }

            Console.WriteLine(cipher);
        }
    }
}
