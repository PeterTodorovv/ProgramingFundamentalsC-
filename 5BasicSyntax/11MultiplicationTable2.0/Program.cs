using System;

namespace _11MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{number1} X {number2} = {number1 * number2}");
                number2++;
            }
            while (number2 <= 10);
            {

                
            }
        }
    }
}
