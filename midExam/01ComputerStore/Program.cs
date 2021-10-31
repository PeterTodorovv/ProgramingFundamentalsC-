using System;

namespace _01ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double priceWithoutTaxes = 0;
            double taxes = 0;

            while(input != "special" && input != "regular")
            {
                double price = double.Parse(input);
                if(price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    priceWithoutTaxes += price;
                    taxes += price * 0.2;
                }
                input = Console.ReadLine();
            }

            double totalPrice = priceWithoutTaxes + taxes;

            if (input == "special") totalPrice -= totalPrice * 0.1;

            if(totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }

        }
    }
}
