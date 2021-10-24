using System;

namespace _10MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int result = GetMultipleOfEvenAndOdds(evenSum, oddSum);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int oddSum, int evenSum)
        {
            int result = oddSum * evenSum;
            return result;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0; 
            string stringNumber = number.ToString();
            for (int i = 0; i < stringNumber.Length; i++)
            {
                int digit = int.Parse(stringNumber[i].ToString());
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
            }
            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;
            string stringNumber = number.ToString();
            for (int i = 0; i < stringNumber.Length; i++)
            {
                int digit = int.Parse(stringNumber[i].ToString());
                if (digit % 2 == 1)
                {
                    oddSum += digit;
                }
            }
            return oddSum;
        }
    }
}
