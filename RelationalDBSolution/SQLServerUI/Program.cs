using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using DataAccessLibrary;
using DataAccessLibrary.Models;

namespace SQLServerUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlCrud sql = new SqlCrud(GetConnectionString());

            //ReadAllContacts(sql);
            //ReadContact(sql, 10);
            CreateNewContact(sql);
            //UpdateContact(sql);




            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static void CreateNewContact(SqlCrud sql)
        {
            FullContactModel user = new FullContactModel
            {
                BasicInfo = new BasicContactModel()
                {
                    FirstName = "crystal",
                    LastName = "Berg"
                }
            };

            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "emafwefil" });
            user.EmailAddresses.Add(new EmailAddressModel { Id = 2, EmailAddress = "koda3wefwef927@gmail" });

            user.PhoneNumbers.Add(new PhoneNumberModel { Id = 1, PhoneNumber = "85064wefwe38941" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "850643wef7747" });

            sql.CreateContact(user);
        }

        private static void ReadAllContacts(SqlCrud sql)
        {
            var rows = sql.GetAllContacts();

            foreach (var row in rows)
            {
                Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}");
            }
        }

        private static void ReadContact(SqlCrud sql, int connectId)
        {
            var contact = sql.GetContactById(connectId);

            Console.WriteLine($"{contact.BasicInfo.Id}: {contact.BasicInfo.FirstName} {contact.BasicInfo.LastName}");
        }

        private static void UpdateContact(SqlCrud sql)
        {
            BasicContactModel contact = new BasicContactModel()
            {
                Id = 1,
                FirstName = "koda",
                LastName = "Berg"
            };
            sql.UpdateContactName(contact);
        }

        private static void RemovePhoneNumberFromContact(SqlCrud sql, int contactId, int phoneNumberId)
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
