using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace MongoDBUI
{
    public class Program
    {
        private static MongoDBDataAccess db;
        private static readonly string tableName = "Contacts";

        static void Main(string[] args)
        {
            db = new MongoDBDataAccess("MongoContactsDB", GetConnectionString());

            ContactModel user = new ContactModel()
            {
                FirstName = "John",
                LastName = "Berg"
            };
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "John@gmail.com" });
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "dakoda3927@gmail.com" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "8506437584" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "6438941" });


            //CreateContact(user);
            //GetAllContacts();
            //4fa0f34c-8765-49cc-b5d9-db9eeb4ba08d guid id
            //GetContactById("4fa0f34c-8765-49cc-b5d9-db9eeb4ba08d");
            //UpdateContactsFirstName("Crystal", "4fa0f34c-8765-49cc-b5d9-db9eeb4ba08d");
            //GetAllContacts();
            //RemovePhoneNumberFromUser("6438941", "4fa0f34c-8765-49cc-b5d9-db9eeb4ba08d");
            //RemoveUser("4fa0f34c-8765-49cc-b5d9-db9eeb4ba08d");

            Console.WriteLine("Done MongoDB");
            Console.ReadLine();
        }

        private static void CreateContact(ContactModel contact)
        {
            db.UpsertRecord(tableName, contact.Id, contact);
        }

        private static void GetAllContacts()
        {
            var contacts = db.LoadRecords<ContactModel>(tableName);

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
            }
        }

        private static void GetContactById(string id)
        {
            Guid guid = new Guid(id);
            var contact = db.LoadRecordById<ContactModel>(tableName, guid);
            Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
        }

        private static void UpdateContactsFirstName(string FirstName, string id)
        {
            Guid guid = new Guid(id);
            var contact = db.LoadRecordById<ContactModel>(tableName, guid);
            contact.FirstName = FirstName;
            db.UpsertRecord(tableName, contact.Id, contact);
        }

        private static void RemovePhoneNumberFromUser(string phoneNumber, string id)
        {
            Guid guid = new Guid(id);
            var contact = db.LoadRecordById<ContactModel>(tableName, guid);
            contact.PhoneNumbers = contact.PhoneNumbers.Where(x => x.PhoneNumber != phoneNumber).ToList();
            db.UpsertRecord(tableName, contact.Id, contact);
        }

        private static void RemoveUser(string id)
        {
            Guid guid = new Guid(id);
            db.DeleteRecord<ContactModel>(tableName, guid);
        }

        private static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Json");

            var config = builder.Build();

            output = config.GetConnectionString(connectionStringName);
            return output;

        }
    }
}
