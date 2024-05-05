using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class RequestAddressData
    {

        public static AddressModel GetAddress()
        {
            AddressModel address = new AddressModel();

            Console.Write("What is your street address: ");
            address.StreetAddress = Console.ReadLine();

            Console.Write("What is your City Name: ");
            address.CityName = Console.ReadLine();

            Console.Write("What State are you located in: ");
            address.StateName = Console.ReadLine();

            Console.Write("What is your Zip Code: ");
            address.ZipCode = Console.ReadLine();

            return address;
        }
    }
}
