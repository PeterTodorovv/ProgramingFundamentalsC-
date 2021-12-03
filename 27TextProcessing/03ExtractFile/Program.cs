using System;

namespace _03ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split("\\");
            string[] file = path[path.Length - 1].Split(".");
            string fileName = file[0];
            string extension = file[1];

            Console.WriteLine($"File name: {fileName}\nFile extension: {extension}");
        }
    }
}
