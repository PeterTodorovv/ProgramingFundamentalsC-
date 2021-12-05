using System;
using System.Text;
using System.Linq;

namespace _01.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder password = new StringBuilder(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "Complete")
            {
                string[] splitted = input.Split();
                string command = splitted[0];
                switch (command)
                {
                    case "Make":
                        int index = int.Parse(splitted[2]);

                        if (splitted[1] == "Upper")
                        {
                            string letter = password[index].ToString().ToUpper();
                            password.Remove(index, 1);
                            password.Insert(index, letter);
                        }
                        else if (splitted[1] == "Lower")
                        {
                            string letter = password[index].ToString().ToLower();
                            password.Remove(index, 1);
                            password.Insert(index, letter);
                        }
                        Console.WriteLine(password);
                        break;
                    case "Insert":
                        index = int.Parse(splitted[1]);
                        if (index < 0 || index >= password.Length)
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        char toInsert = char.Parse(splitted[2]);
                        password.Insert(index, toInsert);
                        Console.WriteLine(password);
                        break;
                    case "Replace":
                        char originalChr = char.Parse(splitted[1]);
                        if (password.ToString().Contains(originalChr))
                        {
                            int value = int.Parse(splitted[2]);
                            char toReplace = (char)(originalChr + value);
                            password.Replace(originalChr, toReplace);
                            Console.WriteLine(password);
                        }
                        break;
                    case "Validation":
                        if (password.Length < 8)
                        {
                            Console.WriteLine("Password must be at least 8 characters long!");
                        }

                        bool condition1 = password.ToString().All(char.IsLetterOrDigit);
                        bool condition2 = password.ToString().All(c => char.IsLetterOrDigit(c) || c == '_');

                        if(!condition1 && !condition2)
                        {
                            Console.WriteLine("Password must consist only of letters, digits and _!");
                        }
                        if (!password.ToString().Any(char.IsUpper))
                        {
                            Console.WriteLine("Password must consist at least one uppercase letter!");
                        }
                        if (!password.ToString().Any(char.IsLower))
                        {
                            Console.WriteLine("Password must consist at least one lowercase letter!");
                        }
                        if (!password.ToString().Any(char.IsDigit))
                        {
                            Console.WriteLine("Password must consist at least one digit!");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}