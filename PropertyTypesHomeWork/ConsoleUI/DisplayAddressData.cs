﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class DisplayAddressData
    {

        public static void ShowFullAddress(AddressModel address)
        {
            Console.WriteLine(address.FullAddress);
        }
    }
}
