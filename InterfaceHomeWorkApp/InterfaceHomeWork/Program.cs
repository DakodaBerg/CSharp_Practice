using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an IRun interface
            //and apply it to a Person class
            //and an Animal class.
            //Store both types in a List<IRun> object.

            List<IRun> runners = new List<IRun>();
            Person person = new Person();
            Animal animal = new Animal();
            runners.Add(person);
            runners.Add(animal);

            Console.ReadLine();
        }
    }
}
