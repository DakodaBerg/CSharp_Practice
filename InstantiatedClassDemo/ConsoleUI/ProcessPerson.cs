﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class ProcessPerson
    {

        public static void GreatPerson(PersonModel person)
        {
            Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
            person.HasBeenGreeted = true;

        }
    }
}
