using System;
using System.Collections.Generic;
using System.Linq;

namespace _01SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numebrs = Console.ReadLine().Split().Select(double.Parse).ToList();

            bool isEven = true;

            while (isEven)
            {
                isEven = false;
                for(int i = 0; i < numebrs.Count - 1; i++)
                {
                    if(numebrs[i] == numebrs[i + 1])
                    {
                        numebrs[i] += numebrs[i + 1];
                        numebrs.RemoveAt(i + 1);
                        isEven = true;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", numebrs));

        }
    }
}
