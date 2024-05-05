using DemoLibrary;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();

            person.FirstName = "Test";
            person.SSN = "12345678"; 
            

            person.SayHello();

            Console.ReadLine();
        }
    }

    public class ModifiedDataAccess : DataAccess
    {
        public void GetUnsecureConnectInfo()
        {
            GetConnectionString();
        }
    }

    public class CEO : Manager
    {
        public void GetConnectInfo()
        {
            DataAccess data = new DataAccess();
            formerLastName = "dako";
        }
    }
}
