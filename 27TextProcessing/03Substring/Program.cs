using System;

namespace _03Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string elementToRemove = Console.ReadLine();
            string text = Console.ReadLine();
            int substringIndex = text.ToLower().IndexOf(elementToRemove.ToLower());

            while(substringIndex != -1)
            {
                text = text.Remove(substringIndex, elementToRemove.Length);
                substringIndex = text.ToLower().IndexOf(elementToRemove.ToLower());
            }

            Console.WriteLine(text);
        }
    }
}
