using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace TextFileUI
{
    public class Program
    {
        private static IConfiguration _config;
        private static string textFile;
        private static TextFileDataAccess db = new TextFileDataAccess();
        static void Main(string[] args)
        {
            InitializeConfiguration();
            textFile = _config.GetValue<string>("TextFile");

            ContactsModel user1 = new ContactsModel();
            user1.FirstName = "Dakoda";
            user1.LastName = "Berg";
            user1.PhoneNumbers.Add("8506438941");
            user1.PhoneNumbers.Add("6438941");
            user1.EmailAddresses.Add("koda3927@gmail.com");
            user1.EmailAddresses.Add("dakoda3927@gmail.com");

            ContactsModel user2 = new ContactsModel();
            user2.FirstName = "john";
            user2.LastName = "Berg";
            user2.PhoneNumbers.Add("8506437584");
            user2.PhoneNumbers.Add("6438941");
            user2.EmailAddresses.Add("john@gmail.com");
            user2.EmailAddresses.Add("dakoda3927@gmail.com");


            //CreateContact(user1);
            //CreateContact(user2);
            //GetAllContacts();
            UpdateFirstName("koda");
            GetAllContacts();

            Console.WriteLine();

            RemovePhoneNumber("6438941");
            GetAllContacts();

            Console.WriteLine("Done");



            Console.ReadLine();
        }

        private static void GetAllContacts()
        {
            var contacts = db.ReadAllRecords(textFile);

            foreach (var c in contacts)
            {
                Console.WriteLine($"{c.FirstName} {c.LastName}");
            }
        }

        private static void CreateContact(ContactsModel contact)
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts.Add(contact);
            db.WriteAllRecords(contacts, textFile);
        }

        private static void UpdateFirstName(string firstName)
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts[0].FirstName = firstName;
            db.WriteAllRecords(contacts, textFile);
        }

        private static void RemovePhoneNumber(string phoneNumber)
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts[0].PhoneNumbers.Remove(phoneNumber);
            db.WriteAllRecords(contacts, textFile);
        }

        private static void RemoveUser()
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts.RemoveAt(0);
            db.WriteAllRecords(contacts, textFile);
        }

        private static void InitializeConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            _config = builder.Build();
        }
    }

}
