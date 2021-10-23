using System;
using System.Linq;

namespace _02CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split().ToArray();
            string[] array2 = Console.ReadLine().Split().ToArray();

            if (array1.Length >= array2.Length)
            {
                for(int i2 = 0; i2 < array2.Length; i2++)
                {
                    for (int i = 0; i < array1.Length; i++)
                    {
                        if (array1[i] == array2[i2]) Console.Write(array2[i2] +" ");
                    }
                }
            }
            else
            {
                for (int i2 = 0; i2 < array2.Length; i2++)
                {
                    for (int i = 0; i < array1.Length; i++)
                    {
                        if (array1[i] == array2[i2]) Console.Write(array1[i] + " ");
                    }
                }
            }
        }
    }
}
