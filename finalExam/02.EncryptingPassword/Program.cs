using System;
using System.Text.RegularExpressions;

namespace _02.EncryptingPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(.+)>([0-9]{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string password = Console.ReadLine();
                if (pattern.IsMatch(password))
                {
                    Match match = Regex.Match(password, @"(.+)>([0-9]{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1");
                    Console.WriteLine($"Password: {match.Groups[2]}{match.Groups[3]}{match.Groups[4]}{match.Groups[5]}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
