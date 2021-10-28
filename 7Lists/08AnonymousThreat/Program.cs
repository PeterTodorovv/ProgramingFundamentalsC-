using System;
using System.Collections.Generic;
using System.Linq;

namespace _08AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();

            while(command != "3:1")
            {
                string[] splittedCommand = command.Split();
                string action = splittedCommand[0];

                if(action == "merge")
                {
                    int startIndex = int.Parse(splittedCommand[1]);
                    int endIndex = int.Parse(splittedCommand[2]);

                    Merger(startIndex, endIndex, data);
                }
                else if(action == "divide")
                {
                    int index = int.Parse(splittedCommand[1]);
                    int partitions = int.Parse(splittedCommand[2]);
                    Divider(index, partitions, data);

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", data));
        }


        static void Merger(int start, int end, List<string> data)
        {
            string newElement = "";
            if (start < 0 || start >= data.Count)
            {
                return;
            }
            for (int i = start; i <= end; i++)
            {
                if (start < 0 || start >= data.Count)
                {
                    continue;
                }

                newElement += data[start];
                data.RemoveAt(start);
                
            }
            data.Insert(start, newElement);
        }


        static void Divider(int index, int partitions, List<string> data)
        {
            List<string> partitionToAdd = new List<string>();
            string element = data[index];
            data.RemoveAt(index);
            int parts = element.Length / partitions;

            for(int i = 0; i < partitions - 1; i++)
            {
                string currentElement = element.Substring(parts * i, parts);
                partitionToAdd.Add(currentElement);
            }

            string lastElement = element.Substring(parts * (partitions - 1));
            partitionToAdd.Add(lastElement);

            
            data.InsertRange(index, partitionToAdd);
        }
    }
}
