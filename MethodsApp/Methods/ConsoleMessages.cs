using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class ConsoleMessages
    {
        public static void SayHi(string firstName)
        {
            Console.WriteLine($"Hello {firstName}!");
        }

        public static void SayGoodBye()
        {
            Console.WriteLine("Goodbye User");
        }

        public static string GetUsersName()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            return name;
        }


        // Tuple lets you return mult values
        public static (string,string) GetFullName()
        {
            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();

            return (firstName,lastName);

        }
    }
}
