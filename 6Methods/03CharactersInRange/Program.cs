using System;

namespace _03CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstElement = char.Parse(Console.ReadLine());
            char secondElement = char.Parse(Console.ReadLine());

            GetMidElements(firstElement, secondElement);
        }

        static void GetMidElements(char firstElement, char secondElement)
        {
            if(firstElement < secondElement)
            {
                for(int i = firstElement+1; i < secondElement; i++)
                    {
                        Console.Write((char)i + " ");
                    }
            }
            else
            {
                for (int i = secondElement + 1; i < firstElement; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            
        }
    }
}
