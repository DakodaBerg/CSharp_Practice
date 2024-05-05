using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace MySqlUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlCrud sql = new MySqlCrud(GetConnectionString());

            //ReadAllContacts(sql);

            //ReadContact(sql, 1);

            // create contact is broken for SQLITE
            //CreateNewContact(sql);

            //UpdateContact(sql);
            RemovePhoneNumberFromContact(sql, 1, 2);

            Console.WriteLine("Done MYSQL");
            Console.ReadLine();
        }

        private static void CreateNewContact(MySqlCrud sql)
        {
            FullContactModel user = new FullContactModel
            {
                BasicInfo = new BasicContactModel()
                {
                    FirstName = "crystal",
                    LastName = "Berg"
                }
            };

            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "cryberg@Gmail.com" });
            user.EmailAddresses.Add(new EmailAddressModel { Id = 2, EmailAddress = "koda3927@gmail" });

            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "8506437747" });
            user.PhoneNumbers.Add(new PhoneNumberModel { Id = 1, PhoneNumber = "8506438941" });

            sql.CreateContact(user);
        }

        private static void ReadAllContacts(MySqlCrud sql)
        {
            var rows = sql.GetAllContacts();

            foreach (var row in rows)
            {
                Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}");
            }
        }

        private static void ReadContact(MySqlCrud sql, int connectId)
        {
            var contact = sql.GetContactById(connectId);

            Console.WriteLine($"{contact.BasicInfo.Id}: {contact.BasicInfo.FirstName} {contact.BasicInfo.LastName}");
        }

        private static void UpdateContact(MySqlCrud sql)
        {
            BasicContactModel contact = new BasicContactModel()
            {
                Id = 1,
                FirstName = "koda",
                LastName = "Berg"
            };
            sql.UpdateContactName(contact);
        }

        private static void RemovePhoneNumberFromContact(MySqlCrud sql, int contactId, int phoneNumberId)
        {
            sql.RemovePhoneNumberFromContact(contactId, phoneNumberId);
        }

        private static string GetConnectionString(string connectionStringName = "Default")
        {
            string ouput = "";

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();

            ouput = config.GetConnectionString(connectionStringName);

            return ouput;
        }
    }
}
