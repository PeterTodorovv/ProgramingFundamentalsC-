﻿using System;

namespace _01SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Print(number);
        }

        static void Print(int number)
        {
            if (number > 0) Console.WriteLine($"The number {number} is positive.");
            else if (number == 0) Console.WriteLine($"The number 0 is zero.");
            else Console.WriteLine($"The number {number} is negative.");
        }
    }
}
