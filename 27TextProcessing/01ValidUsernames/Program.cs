using System;

namespace _01ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            foreach(var password in input)
            {
                if(password.Length >= 3 && password.Length <= 16)
                {
                    bool isValid = true;
                    for(int i = 0; i < password.Length; i++)
                    {
                        if(!char.IsDigit(password[i]) && !char.IsLetter(password[i]) && password[i] != '_' && password[i] != '-')
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid) Console.WriteLine(password);
                }
            }
        }
    }
}
