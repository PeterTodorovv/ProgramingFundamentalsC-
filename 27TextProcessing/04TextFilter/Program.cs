using System;
using System.Text;

namespace _04TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine().Split(", ");
            StringBuilder text = new StringBuilder(Console.ReadLine());
            bool WordsLeftToReplace = true;

            foreach(var bannedWord in banList)
            {
                text.Replace(bannedWord, new string('*', bannedWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
