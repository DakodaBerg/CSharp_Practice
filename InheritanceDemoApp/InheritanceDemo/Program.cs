﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone>();

            phones.Add(new Cellphone());
            phones.Add(new SmartPhone());

            foreach (var phone in phones)
            {
                if (phone is Cellphone cell)
                {
                    cell.Carrier = "";
                }
                if (phone is SmartPhone smartphone)
                {
                    smartphone.ConnectToInternet();
                }
            }

            Console.ReadLine();
        }
    }

    public class WalkieTalkie
    {

    }
}
