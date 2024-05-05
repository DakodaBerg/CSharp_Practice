using EFConsoleUI.DataAccess;
using EFConsoleUI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CreateDakoda();
            //CreateJohn();
            //ReadById(1);
            //UpdateFirstName(1, "Koda");
            //ReadAll();
            //RemovePhoneNumber(1, "6438941");
            RemoveUser(1);
            ReadAll();


            Console.WriteLine("Done Processing");
            Console.ReadLine();
        }

        private static void CreateDakoda()
        {
            var c = new Contact()
            {
                FirstName = "Dakoda",
                LastName = "Berg"
            };
            c.EmailAddresses.Add(new Email { EmailAddress = "koda3927@gmail.com" });
            c.EmailAddresses.Add(new Email { EmailAddress = "dakoda3927@gmail.com" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "8506438941" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "6438941" });

            using (var db = new ContactContext())
            {
                db.Contacts.Add(c);
                db.SaveChanges();
            }
        }

        private static void CreateJohn()
        {
            var c = new Contact()
            {
                FirstName = "John",
                LastName = "Berg"
            };
            c.EmailAddresses.Add(new Email { EmailAddress = "john3927@gmail.com" });
            c.EmailAddresses.Add(new Email { EmailAddress = "dakoda3927@gmail.com" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "8506437584" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "6438941" });

            using (var db = new ContactContext())
            {
                db.Contacts.Add(c);
                db.SaveChanges();
            }
        }

        private static void ReadAll()
        {
            using (var db = new ContactContext())
            {
                var records = db.Contacts
                    .Include(e => e.EmailAddresses)
                    .Include(p => p.PhoneNumbers)
                    .ToList();

                foreach (var c in records)
                {
                    Console.WriteLine($"{c.FirstName} {c.LastName}");
                }
            }
        }

        private static void ReadById(int id)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts.Where(c => c.Id == id).First();
                Console.WriteLine($"{user.FirstName} {user.LastName}");

            }
        }

        private static void UpdateFirstName(int id, string firstName)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts.Where(c => c.Id == id).First();

                user.FirstName = firstName;

                db.SaveChanges();
            }
        }

        private static void RemovePhoneNumber(int id, string phoneNumber)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts
                    .Include(p => p.PhoneNumbers)
                    .Where(c => c.Id == id).First();

                user.PhoneNumbers.RemoveAll(p => p.PhoneNumber == phoneNumber);
                db.SaveChanges();
            }
        }

        private static void RemoveUser(int id)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts
                    .Include(e => e.EmailAddresses)
                    .Include(p => p.PhoneNumbers)
                    .Where(c => c.Id == id).First();
                db.Contacts.Remove(user);
                db.SaveChanges();
            } 
        }
    }
}
