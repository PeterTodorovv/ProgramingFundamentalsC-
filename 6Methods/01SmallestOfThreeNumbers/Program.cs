using System;

namespace _01SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int smallest = GetMin(n1, n2, n3);
            Console.WriteLine(smallest);
        }

        static int GetMin(int n1, int n2, int n3)
        {
            if (n1 < n2 && n1 < n3) return n1;
            else if (n2 < n1 && n2 < n3) return n2;
            return n3;
        }
    }
}
