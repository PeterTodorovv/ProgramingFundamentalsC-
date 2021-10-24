using System;

namespace _10TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for(int i = 1; i <= range; i++)
            {
                TestIfTop(i);
            }

        }

        static void TestIfTop(int number)
        {
            if(CheckIfDivisibleBy8(number) && CheckForOddDigit(number))
            {
                Console.WriteLine(number);
            }
        }


        static bool CheckIfDivisibleBy8(int number)
        {
            int sum = 0;
            foreach (var element in number.ToString())
            {
                sum += int.Parse(element.ToString());
            }
            if (sum % 8 == 0) return true;
            else return false;
        }

        static bool CheckForOddDigit(int number)
        {
            foreach (var element in number.ToString())
            {
                int digit = int.Parse(element.ToString());
                if (digit % 2 == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
