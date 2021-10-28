using System;
using System.Collections.Generic;

namespace _04ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for(int i = 1; i <= n; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }
            products.Sort();

            for(int j = 0; j < n; j++)
            {
                Console.WriteLine($"{j+1}.{products[j]}");
            }
        }
    }
}
