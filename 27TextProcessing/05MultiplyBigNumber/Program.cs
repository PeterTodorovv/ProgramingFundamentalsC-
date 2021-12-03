using System;
using System.Text;

namespace _05MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            StringBuilder newNunber =  new StringBuilder();
            int smallNumber = int.Parse(Console.ReadLine());
            if(smallNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int leftover = 0;

            for(int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int number = (int.Parse(bigNumber[i].ToString()) * smallNumber) + leftover;
                if(number<= 9)
                {
                    leftover = 0;
                    newNunber.Insert(0, number);
                }
                else
                {
                    string stringedNumber = number.ToString();
                    int numberToReplace = int.Parse(stringedNumber[1].ToString());
                    newNunber.Insert(0, numberToReplace);
                    leftover = int.Parse(stringedNumber[0].ToString());
                }
            }

            if (leftover > 0) newNunber.Insert(0, leftover);

            Console.WriteLine(newNunber);
        }
    }
}
