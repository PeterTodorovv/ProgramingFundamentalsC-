using System;
using System.Collections.Generic;
using System.Linq;

namespace _03ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());
            Dictionary<string, string> composers = new Dictionary<string, string>();
            Dictionary<string, string> keys = new Dictionary<string, string>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                if (!composers.ContainsKey(piece))
                {
                    keys.Add(piece, key);
                    composers.Add(piece, composer);
                }
            }

            string cInput = Console.ReadLine();
            while (cInput != "Stop")
            {
                string[] splittedCInput = cInput.Split("|");
                string command = splittedCInput[0];

                if(command == "Add")
                {
                    string piece = splittedCInput[1];
                    string composer = splittedCInput[2];
                    string key = splittedCInput[3];

                    if (!composers.ContainsKey(piece))
                    {
                        composers.Add(piece, composer);
                        keys.Add(piece, key);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if(command == "Remove")
                {
                    string piece = splittedCInput[1];
                    if (keys.ContainsKey(piece))
                    {
                        composers.Remove(piece);
                        keys.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    
                }
                else if(command == "ChangeKey")
                {
                    string piece = splittedCInput[1];
                    string newKey = splittedCInput[2];

                    if (keys.ContainsKey(piece))
                    {
                        keys[piece] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                cInput = Console.ReadLine();
            }

            foreach(var piece in composers.OrderBy(p => p.Key).ThenBy(p => p.Value))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value}, Key: {keys[piece.Key]}");
            }
        }
    }
}
