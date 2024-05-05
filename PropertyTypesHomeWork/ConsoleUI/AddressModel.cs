using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class AddressModel
    {

        public string StreetAddress { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string ZipCode { get; set; }


        public string FullAddress
        {
            get
            {
                string fullAddress = $"The full adress is {StreetAddress} " +
                    $"{CityName} " +
                    $"{StateName} " +
                    $"{ZipCode}";
                return fullAddress;
            }
        }
    }


}
