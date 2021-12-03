using System;
using System.Text;

namespace _06ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder newString = new StringBuilder();
            char lastElement = ' ';

            foreach(var element in input)
            {
                if(lastElement != element)
                {
                    newString.Append(element);
                }

                lastElement = element;
            }

            Console.WriteLine(newString);
        }
    }
}
