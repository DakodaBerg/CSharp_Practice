using LinqUI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqUI
{
    public class SampleData
    {
        public static List<ContactModel> GetContactData()
        {
            List<ContactModel> ouput = new List<ContactModel>
            {
                new ContactModel{Id = 1,FirstName = "crystal",LastName = "_test_",Addresses = new List<int> {2}},
                new ContactModel{Id = 2,FirstName = "megan",LastName = "berg",Addresses = new List<int> {1,2,3,4}},
                new ContactModel{Id = 3,FirstName = "ryan",LastName = "james",Addresses = new List<int> {1,2,4}},
                new ContactModel{Id = 4,FirstName = "dakoda",LastName = "smith",Addresses = new List<int> {2,5}},
                new ContactModel{Id = 5,FirstName = "jeff",LastName = "a",Addresses = new List<int> {5}},
                new ContactModel{Id = 6,FirstName = "john",LastName = "aegr",Addresses = new List<int> {1}}
            };
            return ouput;
        }

        public static List<AddressModel> GetAddressData()
        {
            List<AddressModel> output = new List<AddressModel>()
            {
                new AddressModel{Id = 1, City = "bristol",State = "FL"},
                new AddressModel{Id = 2, City = "dothan",State = "AL"},
                new AddressModel{Id = 3, City = "austin",State = "TX"},
                new AddressModel{Id = 4, City = "atlanta",State = "GA"},
                new AddressModel{Id = 5, City = "New york",State = "NY"}
            };
            return output;
        }
    }
}
