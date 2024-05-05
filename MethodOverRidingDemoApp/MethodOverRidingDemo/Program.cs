using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRidingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel()
            {
                FirstName = "Test1",
                LastName = "Test2",
                Email = "Test3",
            };

            Corolla corolla = new Corolla();
            


            Console.WriteLine(person);
            Console.ReadLine();
        }
    }
}
