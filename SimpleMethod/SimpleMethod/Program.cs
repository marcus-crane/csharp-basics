using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    class Program
    {
        // Main is the entrypoint of our program / void means the function itself returns nothing and it can accept arguments
        static void Main(string[] args)
        {
            string firstName, lastName, homeTown;

            Console.WriteLine("Welcome! Tell me about yourself?");

            Console.Write("What is your first name: ");
            firstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            lastName = Console.ReadLine();

            Console.Write("What is your hometown: ");
            homeTown = Console.ReadLine();

            Respond(firstName, lastName, homeTown);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Respond method is private so it can't be accessed outside of the Program class(?) and is void so it returns no value
        private static void Respond(string firstName, string lastName, string homeTown)
        {
            Console.WriteLine(String.Format("If we reversed the information you entered, you would become {0} {1} from {2}",
                ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(homeTown)
                ));
        }

        // ReverseString method is private and returns a string
        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            return string.Concat(messageArray).ToLower();
        }
    }
}
