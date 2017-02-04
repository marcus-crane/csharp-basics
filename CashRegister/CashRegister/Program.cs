using System;

namespace CashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            double applePrice, bananaPrice, orangePrice, total;
            int appleQuantity, bananaQuantity, orangeQuantity;

            applePrice = 2.99;
            bananaPrice = 3.99;
            orangePrice = 4.99;

            Console.WriteLine("How many apples are you purchasing?");
            appleQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine("How many bananas are you purchasing?");
            bananaQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine("How many oranges are you purchasing");
            orangeQuantity = int.Parse(Console.ReadLine());

            total = (applePrice * appleQuantity) + (bananaPrice * bananaQuantity) + (orangePrice * orangeQuantity);

            Console.WriteLine("That's {0} apples, {1} bananas and {2} oranges for a total of ${3}", appleQuantity, bananaQuantity, orangeQuantity, total);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
