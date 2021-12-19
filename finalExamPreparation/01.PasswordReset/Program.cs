using System;
using System.Text;

namespace _01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder password = new StringBuilder(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            while(input[0] != "Done")
            {
                string action = input[0];

                switch (action)
                {
                    case "TakeOdd":
                        password = ReturnOdd(password);
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        int index = int.Parse(input[1]);
                        int length = int.Parse(input[2]);
                        password = password.Remove(index, length);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string element1 = input[1];
                        string element2 = input[2];
                        if (!password.ToString().Contains(element1))
                        {
                            Console.WriteLine("Nothing to replace!");
                            input = Console.ReadLine().Split();
                            continue;
                        }
                        password = password.Replace(element1, element2);

                        Console.WriteLine(password);
                        break;
                }
                input = Console.ReadLine().Split();
            }

            Console.WriteLine($"Your password is: {password}");
        }

        public static StringBuilder ReturnOdd(StringBuilder oldPassword)
        {
            StringBuilder newPassword = new StringBuilder("");

            for(int i = 1; i < oldPassword.Length; i+=2)
            {
                newPassword.Append(oldPassword[i]);
            }

            return newPassword;
        }
    }
}
