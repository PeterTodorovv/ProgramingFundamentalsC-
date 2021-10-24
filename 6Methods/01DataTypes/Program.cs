using System;

namespace _01DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            if(dataType == "int")
            {
                InputInt();
            }
            else if(dataType == "real")
            {
                InputReal();
            }
            else if (dataType == "string")
            {
                InputString();
            }
        }

        static void InputInt()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number * 2);
        }

        static void InputReal()
        {
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(number * 1.5):f2}");
        }

        static void InputString()
        {
            string text = Console.ReadLine();

            Console.WriteLine($"${text}$");
        }
    }
}
