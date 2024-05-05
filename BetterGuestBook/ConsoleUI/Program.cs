using System;
using GuestBookLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Capture the info about each guest
// info to capture: first name, last name, message to host
// once done, lop through each guest and print their info


namespace ConsoleUI
{
    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();
        static void Main(string[] args)
        {


            GetGuestInfo();
            PrintGuestInfo();


            Console.ReadLine();
        }

        private static void PrintGuestInfo()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }

        private static void GetGuestInfo()
        {
            string moreGuestComing = "";

            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetInfoFromConsole("What is your first name:");          
                guest.LastName = GetInfoFromConsole("What is your last name:");
                guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host:");
                moreGuestComing = GetInfoFromConsole("Are more guest coming (yes/no): ");
                guests.Add(guest);
                Console.Clear();
            } while (moreGuestComing.ToLower() == "yes");
        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }
    }
}
