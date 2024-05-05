using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHomeWork
{
    public static class ConsoleGreetings
    {

        public static void WelcomeUser()
        {
            Console.WriteLine("Hello!!");
        }

        public static (string, string) AskForUsersName()
        {
            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();

            return (firstName, lastName);
        }

        public static void CallUserByName(string firstName, string lastName)
        {
            Console.WriteLine($"Hello {firstName} {lastName}.");
        }

    }
}
