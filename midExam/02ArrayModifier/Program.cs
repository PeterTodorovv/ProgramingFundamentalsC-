using System;
using System.Linq;

namespace _02ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] splittedCommand = command.Split();
                string action = splittedCommand[0];

                if(action == "swap")
                {
                    int index1 = int.Parse(splittedCommand[1]);
                    int index2 = int.Parse(splittedCommand[2]);
                    Swapper(index1, index2, originalArray);
                }
                else if(action == "multiply")
                {
                    int index1 = int.Parse(splittedCommand[1]);
                    int index2 = int.Parse(splittedCommand[2]);
                    Multiplier(index1, index2, originalArray);
                }
                else if(action == "decrease")
                {
                    Decreaser(originalArray);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", originalArray));
        }

        public static void Swapper(int index1, int index2, int[] array)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public static void Multiplier(int index1, int index2, int[] array)
        {
            int firstNumber = array[index1];
            int secondNumber = array[index2];
            array[index1] = firstNumber * secondNumber;
        }

        public static void Decreaser(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= 1;
            }
        }
    }
}
