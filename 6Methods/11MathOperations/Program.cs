using System;

namespace _11MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double result = Calculator(firstNumber, operation, secondNumber);
            result = Math.Round(result, 2);
            Console.WriteLine(result);
        }

        static double Calculator(double firstNumber, char operation, double secondNumber)
        {
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    result= firstNumber / secondNumber;
                    break;
            }
            return result;
        }
    }
}
