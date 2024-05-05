using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DataAccess
    {
        protected internal string GetConnectionString()
        {
            return "returns Sensitive data";
        }
    }

    public class Person
    {
        protected string formerLastName = "";

        public string FirstName { get; set; }
        public string LastName { get; set; }


        private string _ssn;

        public string SSN
        {
            get { return $"***-**-{_ssn.Substring(_ssn.Length - 4)}"; }
            set { _ssn = value; }
        }

        public void ChangeLastName(string newLastName)
        {
            formerLastName = LastName;
            LastName = newLastName;
        }

        public void SayHello()
        {
            Console.WriteLine($"Say Hello {FirstName} {SSN}");
        }

        public void SavePerson()
        {
            DataAccess dataAccess = new DataAccess();
            string conn = dataAccess.GetConnectionString();
            // saves the person
        }
    }

    public class Employee : Person
    {
        public string GetFormerLastName()
        {
            return formerLastName;
        }
    }

    public class Manager : Employee
    {
        public string GetAllNames()
        {
            return $"{FirstName},{LastName},{formerLastName}";
        }
    }
}
