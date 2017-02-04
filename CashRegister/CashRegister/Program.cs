using System;

namespace CashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            const double applePrice = 2.99;
            const double bananaPrice = 3.99;
            const double orangePrice = 4.99;

            Console.WriteLine("The price of buying one of each fruit would be {0}", applePrice + bananaPrice + orangePrice);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
