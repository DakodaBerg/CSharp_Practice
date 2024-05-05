using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            DisplayAddressData.ShowFullAddress(RequestAddressData.GetAddress());
            Console.ReadLine();
        }
    }
}
