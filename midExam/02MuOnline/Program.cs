using System;

namespace _02MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split('|');
            int health = 100;
            int bitcoins = 0; 

            for(int i = 0; i < rooms.Length; i++)
            {
                string room = rooms[i];
                string[] roomElemets = room.Split();
                string command = roomElemets[0];
                int number = int.Parse(roomElemets[1]);

                if(command == "potion")
                {
                    health += number;
                    if (health > 100) {
                        int diff = health - 100;
                        number -= diff;
                        health = 100;
                    } 

                    Console.WriteLine($"You healed for {number} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if(command == "chest")
                {
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    health -= number;
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }

                    Console.WriteLine($"You slayed {command}.");
                }
            }

            Console.WriteLine($"You've made it!\nBitcoins: {bitcoins}\nHealth: {health}");
        }
    }
}
