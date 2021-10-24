using System;

namespace _06CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double result = TriangleArea(width, height);
            Console.WriteLine(result);
        }

        static double TriangleArea(double width, double height)
        {
            double result = width * height;
            return result;
        }
    }
}
