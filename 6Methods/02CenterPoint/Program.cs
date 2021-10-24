using System;

namespace _02CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            CloserToCenter(X1, Y1, X2, Y2);
        }

        static void CloserToCenter(double x1, double y1, double x2, double y2)
        {
            double distanceFirstPoint = Math.Abs(x1) + Math.Abs(y1);
            double distanceSecondPoint = Math.Abs(x2) + Math.Abs(y2);

            if(distanceFirstPoint <= distanceSecondPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
