using System;
using System.Collections.Generic;

namespace _03ChatLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chatLog = new List<string>();

            string input = Console.ReadLine();

            while(input != "end")
            {
                string[] splittedInput = input.Split();
                string command = splittedInput[0];

                if(command == "Chat")
                {
                    string message = splittedInput[1];
                    chatLog.Add(message);
                }
                else if(command == "Delete")
                {
                    string message = splittedInput[1];
                    if (chatLog.Contains(message)) chatLog.Remove(message);
                }
                else if(command == "Edit")
                {
                    string message = splittedInput[1];
                    if (chatLog.Contains(message))
                    {
                        string editedVersion = splittedInput[2];
                        int index = chatLog.IndexOf(message);
                        chatLog[index] = editedVersion;
                    }
                }
                else if(command == "Pin")
                {
                    string message = splittedInput[1];
                    if (chatLog.Contains(message))
                    {
                        chatLog.Remove(message);
                        chatLog.Add(message);
                    }
                }
                else if(command == "Spam")
                {
                    for(int i = 1; i < splittedInput.Length; i++)
                    {
                        chatLog.Add(splittedInput[i]);
                    }
                }
                input = Console.ReadLine();
            }
            
            foreach(var message in chatLog)
            {
                Console.WriteLine(message);
            }
        }
    }
}
