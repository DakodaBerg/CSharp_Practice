﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{

    // BluePrint
    public class PersonModel
    {
        //public string firstName;
        //public string lastName;
        //public string emailAddress;

        // auto prop
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string emailAddress { get; set; }
        public bool HasBeenGreeted { get; set; }

    }
}
