using System;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"^@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+$");

            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                if (regex.IsMatch(barcode))
                {
                    string group = "";
                    foreach(var symbol in barcode)
                    {
                        if (char.IsDigit(symbol))
                        {
                            group += symbol;
                        }
                    }

                    if (group == "") group = "00";

                    Console.WriteLine($"Product group: {group}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
