using System;

namespace MethodOverRidingDemo
{
    public class Tesla : Car
    {
        public override void StartCar()
        {
            Console.WriteLine("press on button");
        }

        public override void SetClock()
        {
            Console.WriteLine("Set itself");
        }
    }
}
