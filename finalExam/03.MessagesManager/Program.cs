using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MessagesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = int.Parse(Console.ReadLine());
            Dictionary<string, int> sended = new Dictionary<string, int>();
            Dictionary<string, int> recived = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split("=");

            while(input[0] != "Statistics")
            {
                string command = input[0];
                if(command == "Add")
                {
                    string name = input[1];
                    if (!sended.ContainsKey(name))
                    {
                        int sent = int.Parse(input[2]);
                        int recivedMesseges = int.Parse(input[3]);
                        sended.Add(name, sent);
                        recived.Add(name, recivedMesseges);
                    }
                }
                else if(command == "Message")
                {
                    string sender = input[1];
                    string reciver = input[2];
                    if(sended.ContainsKey(sender) && sended.ContainsKey(reciver))
                    {
                        sended[sender]++;
                        recived[reciver]++;

                        if(sended[sender] + recived[sender] >= maxCapacity)
                        {
                            sended.Remove(sender);
                            recived.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }

                        if (sended[reciver] + recived[reciver] >= maxCapacity)
                        {
                            Console.WriteLine($"{reciver} reached the capacity!");
                            sended.Remove(reciver);
                            recived.Remove(reciver);
                        }
                    }
                }
                else if (command == "Empty")
                {
                    string user = input[1];

                    if(user == "All")
                    {
                        sended.Clear();
                        recived.Clear();
                    }

                    if (sended.ContainsKey(user))
                    {
                        sended.Remove(user);
                        recived.Remove(user);
                    }
                }

                input = Console.ReadLine().Split("=");
            }

            Console.WriteLine($"Users count: {sended.Count}");

            foreach(var user in recived.OrderByDescending(v => v.Value).ThenBy(k => k.Key ))
            {
                Console.WriteLine($"{user.Key} - {user.Value + sended[user.Key]}");
            }

        }
    }
}
