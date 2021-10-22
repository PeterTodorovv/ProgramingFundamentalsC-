using System;

namespace _06TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());

            for (int i = 97; i <= numberOfLetters + 96; i++)
            {
                for(int i2 = 97; i2 <= numberOfLetters + 96; i2++)
            {
                    for (int i3 = 97; i3 <= numberOfLetters + 96; i3++)
                    {
                        Console.WriteLine($"{(char)i}{(char)i2}{(char)i3}");
                    }
            }
            }
                
        }
    }
}
