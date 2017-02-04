using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    class Program
    {
        // Main is the entrypoint of our program
        static void Main(string[] args)
        {
            HelloWorld();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello world!");
        }
    }
}
