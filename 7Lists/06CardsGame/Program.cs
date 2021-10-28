using System;
using System.Collections.Generic;
using System.Linq;

namespace _06CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

            while(true)
            {
                int firstPlayersCard = firstPlayer[0];
                int secondPlayersCard = secondPlayer[0];

                if(firstPlayersCard > secondPlayersCard)
                {
                    firstPlayer.Add(firstPlayersCard);
                    firstPlayer.Add(secondPlayersCard);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else if (firstPlayersCard < secondPlayersCard)
                {
                    secondPlayer.Add(secondPlayersCard);
                    secondPlayer.Add(firstPlayersCard);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                if (firstPlayer.Count == 0)
                {
                    int sum = secondPlayer.Sum();
                    Console.Write($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (secondPlayer.Count == 0)
                {
                    int sum = firstPlayer.Sum();
                    Console.Write($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}
