using System;
using System.Text;

namespace _02RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            foreach(var element in input)
            {
                StringBuilder word = new StringBuilder();

                for(int i =1; i <= element.Length; i++)
                {
                    word.Append(element);
                }
                Console.Write(word);
            }
        }
    }
}
