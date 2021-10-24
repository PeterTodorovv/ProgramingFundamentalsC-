using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if(LenghtValidator(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if(SymbolsValidator(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if(DigitsCount(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if(LenghtValidator(password) && SymbolsValidator(password) && DigitsCount(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool LenghtValidator(string password)
        {
            if(password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }

        static bool SymbolsValidator(string password)
        {
            foreach(var symbol in password)
            {
                if (char.IsLetterOrDigit(symbol) == false){
                    return false;
                }
                
            }
            return true;
        }

        static bool DigitsCount(string password)
        {
            int totalDigits = 0;
            foreach(var symbol in password)
            {
                if (char.IsDigit(symbol)) totalDigits++;
            }
            if (totalDigits >= 2) return true;
            return false;
        }
    }
}
