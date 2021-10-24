using System;

namespace _09GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "string":
                    string a = Console.ReadLine();
                    string b = Console.ReadLine();
                    Console.WriteLine(GetMax(a, b));
                    break;
                case "int":
                    int c = int.Parse(Console.ReadLine());
                    int d = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(c, d));
                    break;
                case "char":
                    char e = char.Parse(Console.ReadLine());
                    char f = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(e, f));
                    break;
            }
        }

        static string GetMax(string a, string b)
        {
            int result = a.CompareTo(b);
            int firstSum = 0;
            int secondSum = 0;
            firstSum = LetterSum(a, firstSum);
            secondSum = LetterSum(b, secondSum);

            if (result > 0)
            {
                return a;
            }
            return b;
        }


        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }

        private static int LetterSum(string a, int firstSum)
        {
            for (int i = 0; i < a.Length; i++)
            {
                firstSum += a[i];
            }

            return firstSum;
        }
    }
}
