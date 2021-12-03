using System;

namespace _02CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(CharacterMultiplier(input));

        }

        static int CharacterMultiplier(string[] array)
        {
            string first = array[0];
            string second = array[1];
            int sum = 0;

            if(first.Length > second.Length)
            {
                for (int i = 0; i < second.Length; i++)
                {
                    sum += first[i] * second[i];
                }

                string substring = first.Substring(second.Length);

                for (int i = 0; i < substring.Length; i++)
                {
                    sum += substring[i];
                }
            }
            else if(second.Length > first.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += first[i] * second[i];
                }

                string substring = second.Substring(first.Length);

                for (int i = 0; i < substring.Length; i++)
                {
                    sum += substring[i];
                }
            }
            else
            {

                for (int i = 0; i < first.Length; i++)
                {
                    sum += first[i] * second[i];
                }
            }

            return sum;
        }
    }
}
