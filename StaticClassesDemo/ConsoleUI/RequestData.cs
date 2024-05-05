using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class RequestData
    {
        public static double GetADouble(string message)
        {
            Console.Write(message);
            string numberText = Console.ReadLine();
            double output;
            bool isValidDouble = double.TryParse(numberText, out output);

            while (isValidDouble == false)
            {
                Console.WriteLine("That was not a valid number, please try again.");
                Console.Write(message);
                numberText = Console.ReadLine();
                isValidDouble = double.TryParse(numberText, out output);
            }
            return output;
        }

        public static string GetAString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();
            return output;
        }
    }
}
