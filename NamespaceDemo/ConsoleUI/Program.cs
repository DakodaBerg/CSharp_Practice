using System;
using System.Collections.Generic;
using ConsoleUI.Models;
using FoundationInfo;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            List<PersonModel> list = new List<PersonModel>();

            //Changed namespace
            //Calculations.add(10, 12);

            //full name
            //ConsoleUI.Calculations.add(20, 13);

            //using statments allows me not to have to type it all out
            FoundationInfo.Calculations.add(10, 12);

            Calculations.add(4, 3);

            Console.ReadLine();
        }
    }
}
