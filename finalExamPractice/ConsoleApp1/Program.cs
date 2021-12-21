using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            string input = Console.ReadLine();

            while(input != "Decode")
            {
                string[] splittedInput = input.Split("|");
                string command = splittedInput[0];
                
                if(command == "Move")
                {
                    int numberOfLetters = int.Parse(splittedInput[1]);
                    for(int i = 1; i <= numberOfLetters; i++)
                    {
                        encryptedMessage += encryptedMessage[0];
                        encryptedMessage = encryptedMessage.Remove(0, 1);
                    }
                }
                else if(command == "Insert")
                {
                    int index = int.Parse(splittedInput[1]);
                    string value = splittedInput[2];
                    encryptedMessage = encryptedMessage.Insert(index, value);
                }
                else if(command == "ChangeAll")
                {
                    string substring = splittedInput[1];
                    string replacement = splittedInput[2];
                    encryptedMessage = encryptedMessage.Replace(substring, replacement);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("The decrypted message is: " + encryptedMessage);
        }
    }
}
