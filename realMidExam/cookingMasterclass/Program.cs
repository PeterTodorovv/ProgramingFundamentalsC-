using System;

namespace cookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            int flourCount = students;
            int freeFlour = flourCount / 5;
            flourCount -= freeFlour;

            double aronCost = apronPrice * Math.Ceiling((students * 1.2));
            double eggsCost = eggPrice * students * 10;
            double flourCost = flourCount * flourPrice;
            double totalPrice = aronCost + eggsCost + flourCost;

            if(totalPrice <= budget)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$.");
            }
            else
            {
                double diff = totalPrice - budget;
                Console.WriteLine($"{diff:f2}$ more needed.");
            }
        }
    }
}
