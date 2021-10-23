using System;

namespace _04ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split();
            Array.Reverse(arrayOfStrings);
            Console.WriteLine(String.Join(" ", arrayOfStrings));
        }
    }
}
