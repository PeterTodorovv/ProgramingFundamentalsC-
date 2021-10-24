using System;

namespace _07RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());
            string repeatedString = StringRepeater(text, repeats);
            Console.WriteLine(repeatedString);
        }

        static string StringRepeater(string text, int repeats)
        {
            string repeatedString = "";
            for(int i = 1; i <= repeats; i++)
            {
                repeatedString += text;
            }
            return repeatedString;
        }
    }
}
