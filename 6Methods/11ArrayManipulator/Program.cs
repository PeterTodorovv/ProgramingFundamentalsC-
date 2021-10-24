using System;
using System.Linq;

namespace _11ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] commandArray = command.Split();
                string action = commandArray[0];

                if(action == "exchange")
                {
                    int index = int.Parse(commandArray[1]);
                    if (index < originalArray.Length && index >= 0)
                    {
                        exchange(originalArray, index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (action == "max")
                {
                    string type = commandArray[1];
                    if(type == "odd")
                    {
                        int maxOdd = GetMax(originalArray, 1);
                        if (maxOdd != -1)
                            Console.WriteLine(maxOdd);
                        else
                            Console.WriteLine("No matches");
                    }
                    else if (type == "even")
                    {
                        int maxEven = GetMax(originalArray, 0);
                        if (maxEven != -1)
                            Console.WriteLine(maxEven);
                        else
                            Console.WriteLine("No matches");
                    }
                }
                else if (action == "min")
                {
                    string type = commandArray[1];
                    if (type == "odd")
                    {
                        int minOdd = GetMin(originalArray, 1);
                        if (minOdd != -1)
                            Console.WriteLine(minOdd);
                        else
                            Console.WriteLine("No matches");
                    }
                    else if (type == "even")
                    {
                        int minEven = GetMin(originalArray, 0);
                        if (minEven != -1)
                            Console.WriteLine(minEven);
                        else
                            Console.WriteLine("No matches");
                    }
                }
                else if(action == "first")
                {
                    int count = int.Parse(commandArray[1]);
                    string type = commandArray[2];

                    if(count > originalArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else if (type == "odd")
                    {
                        string result = GetFirst(originalArray, count, 1);
                        if (result == "[]") Console.WriteLine(result);
                        else
                        {
                            string[] returnArray = result.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            string printString = String.Join(", ", returnArray);
                            Console.WriteLine($"[{printString}]");
                        }
                    }
                    else if (type == "even")
                    {
                        string result = GetFirst(originalArray, count, 0);
                        if (result == "[]") Console.WriteLine(result);
                        else
                        {
                            string[] returnArray = result.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            string printString = String.Join(", ", returnArray);
                            Console.WriteLine($"[{printString}]");
                        }
                    }
                }
                else if (action == "last")
                {
                    int count = int.Parse(commandArray[1]);
                    string type = commandArray[2];
                    if (count > originalArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else if (type == "odd")
                    {
                        string result = GetLast(originalArray, count, 1);
                        if (result == "[]") Console.WriteLine(result);
                        else
                        {
                            string[] returnArray = result.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            Array.Reverse(returnArray);
                            string printString = String.Join(", ", returnArray);
                            Console.WriteLine($"[{printString}]");
                        }
                    }
                    else if (type == "even")
                    {
                        string result = GetLast(originalArray, count, 0);
                        if (result == "[]") Console.WriteLine(result);
                        else
                        {
                            string[] returnArray = result.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            Array.Reverse(returnArray);
                            string printString = String.Join(", ", returnArray);
                            Console.WriteLine($"[{printString}]");
                        }
                    }
                }



                command = Console.ReadLine();
            }
            string arrayToPrint = String.Join(", ", originalArray);
            Console.WriteLine($"[{arrayToPrint}]");
        }





        static void exchange(int[] originalArray, int index)
        {
            int[] firstPart = new int[index + 1];
            int[] secondPart = new int[originalArray.Length - index - 1];
            int[] newArray = new int[originalArray.Length];


                for (int i = 0; i <= index; i++)
                {
                    firstPart[i] = originalArray[i];
                }
                for (int i = 0; i < originalArray.Length - index -1; i++)
                {
                    secondPart[i] = originalArray[i + index + 1];
                }
            newArray = secondPart.Concat(firstPart).ToArray();
            for(int i  = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = newArray[i];
            }
        }


        static int GetMax(int[] originalArray, int inputNumber)
        {
            int biggestNumber = int.MinValue;
            int index = -1;
            int currentIndex = 0;

            foreach(int digit in originalArray)
            {
                if (digit % 2 == inputNumber)
                {
                    if (digit >= biggestNumber)
                    {
                        biggestNumber = digit;
                        index = currentIndex;
                    }
                }
                currentIndex++;
            }
            if (index != -1) return index;
            return index;
        }

        static int GetMin(int[] originalArray, int inputNumber)
        {
            int smallestNumber = int.MaxValue;
            int index = -1;
            int currentIndex = 0;

            foreach (int digit in originalArray)
            {
                if (digit % 2 == inputNumber)
                {
                    if (digit <= smallestNumber)
                    {
                        smallestNumber = digit;
                        index = currentIndex;
                    }
                }
                currentIndex++;
            }
            if (index != -1) return index;
            return index;
        }

        static string GetFirst(int[] originalArray, int numberCount, int inputNumber)
        {
            string numbersToReturn = string.Empty;
            int currentIndex = 0;

            foreach (int digit in originalArray)
            {
                if (digit % 2 == inputNumber)
                {
                    currentIndex++;
                    numbersToReturn += digit + " ";
                    if (currentIndex == numberCount) break;
                }
            }
            if(numbersToReturn != string.Empty)
            {
                return numbersToReturn;
            }
            return "[]";
        }

        static string GetLast(int[] originalArray, int numberCount, int inputNumber)
        {
            string numbersToReturn = string.Empty;
            int currentIndex = 0;

            for(int i = originalArray.Length - 1; i >= 0; i--)
            {
                if (originalArray[i] % 2 == inputNumber)
                {
                    currentIndex++;
                    numbersToReturn += originalArray[i] + " ";
                    if (currentIndex == numberCount) break;
                }
            }
            if (numbersToReturn != string.Empty)
            {
                return numbersToReturn;
            }
            return "[]";
        }
    }
}
