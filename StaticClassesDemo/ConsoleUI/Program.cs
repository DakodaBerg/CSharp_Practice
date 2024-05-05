using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {

        //static means you that you get one copy for your entire app
        static void Main(string[] args)
        {

            string firstName = RequestData.GetAString("What is your first name:");

            UserMessages.ApplicationStartMessage(firstName);

            double x = RequestData.GetADouble("Please enter your first Number: ");
            double y = RequestData.GetADouble("Please enter your second Number: ");

            double result = CalculateData.Add(x, y);

            UserMessages.PrintResultMessage($"The sum of {x} and {y} is {result}");

            Console.ReadLine();
        }


        // static method inside our class
        private static void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
