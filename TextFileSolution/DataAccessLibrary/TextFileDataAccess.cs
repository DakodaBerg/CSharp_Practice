using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace DataAccessLibrary
{
    public class TextFileDataAccess
    {
        public List<ContactsModel> ReadAllRecords(string textFile)
        {
            if (File.Exists(textFile) == false)
            {
                return new List<ContactsModel>();
            }
            var lines = File.ReadAllLines(textFile);

            List<ContactsModel> outPut = new List<ContactsModel>();
            foreach (var line in lines)
            {
                ContactsModel c = new ContactsModel();
                var vals = line.Split(',');

                if (vals.Length < 4)
                {
                    throw new Exception($"Invalid row of data: {line}");
                }

                c.FirstName = vals[0];
                c.LastName = vals[1];
                c.PhoneNumbers = vals[2].Split(';').ToList();
                c.EmailAddresses = vals[3].Split(';').ToList();
                outPut.Add(c);
            }
            return outPut;

        }

        public void WriteAllRecords(List<ContactsModel> contacts, string textFile)
        {
            List<string> lines = new List<string>();

            foreach (var c in contacts)
            {
                lines.Add($"{c.FirstName},{c.LastName},{String.Join(';', c.PhoneNumbers)},{String.Join(';', c.EmailAddresses)}");
            }
            File.WriteAllLines(textFile, lines);
        }
    }
}
