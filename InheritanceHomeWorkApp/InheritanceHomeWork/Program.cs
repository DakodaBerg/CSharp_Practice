using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a vehicle class,
            //a car class a boat class,
            //and a motorcycle class.
            //Identify what inheritance should happen,
            //if any, and wire it up


            Console.ReadLine();
        }
    }

    public class Vehicle
    {
        public string TypeOfEngine { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string MakerName { get; set; }

        public static void StartVehicle()
        {

        }
        public static void StopVehicle()
        {

        }

    }

    public class Car : Vehicle
    {
        public string ModelOfCar { get; set; }
        public int WeightOfCar { get; set; }
        public string DriverLicense { get; set; }

    }

    public class Boat
    {
        public string TypeOfEngine { get; set; }
        public string MakerName { get; set; }
        public int SizeOfBoat { get; set; }
        public static void StartVehicle()
        {

        }
        public static void StopVehicle()
        {

        }
        public static void GoFishing()
        {

        }
    }

    public class Motorcycle : Vehicle
    {
        public string StyleOfMotorcycle { get; set; }
        public string ColourOfMotorcycle { get; set; }
        public string MotorcycleLicense { get; set; }
        public static void PopWheelie()
        {

        }

    }
}
