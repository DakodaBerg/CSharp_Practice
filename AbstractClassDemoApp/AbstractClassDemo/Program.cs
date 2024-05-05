using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Manufactuer = "toyota";

            Console.ReadLine();
        }
    }

    public abstract class Vehicle
    {
        public int VIN { get; set; }
        public string Manufactuer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
    }

    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; } = 4;

    }
}
