using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MiniProjectGuestBook
{
    public static class GuestBook
    {
        public static List<string> NameOfParty()
        {
            Console.Write("Whats the name of your party: ");
            string data = Console.ReadLine();

            List<string> allNames = new List<string>();
            allNames.Add(data);

            return allNames;

        }

        public static List<int> SizeOfParty()
        {
            Console.Write("How many people are in your party: ");
            int data;
            bool isValidInt = int.TryParse(Console.ReadLine(), out data);
            List<int> totalNumOfGuest = new List<int>();
            totalNumOfGuest.Add(data);

            return totalNumOfGuest;
        }

        public static void IsPartyOver(List<string> allNames, List<int> totalNumOfGuest)
        {
            Console.Write("Has everyone signed the Guest Book: ");
            string response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                ShowGuestBook(allNames, totalNumOfGuest);
            }
            else
            {
                NameOfParty();
                SizeOfParty();
                IsPartyOver(allNames, totalNumOfGuest);
            }
        }

        public static void ShowGuestBook(List<string> allNames, List<int> totalNumOfGuest)
        {
            for (int i = 0; i < allNames.Count; i++)
            {
                Console.WriteLine(allNames[i]);
            }

            int sum = 0;

            for (int i = 0; i < totalNumOfGuest.Count; i++)
            {
                sum += totalNumOfGuest[i];
            }
            Console.WriteLine(sum);
        }
    }
}
