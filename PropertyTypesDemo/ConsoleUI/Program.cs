using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PersonModel person = new PersonModel();


            person.FirstName = "dakoda";
            //person.LastName = "berg";
            person.SSN = "123-45-6789";

            Console.WriteLine(person.SSN);
            Console.WriteLine(person.FullName);


            Console.ReadLine();
        }
    }
}
