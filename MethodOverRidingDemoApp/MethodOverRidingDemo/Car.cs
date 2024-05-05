using System;

namespace MethodOverRidingDemo
{
    public abstract class Car
    {
        public virtual void StartCar()
        {
            Console.WriteLine("turn key and start");
        }

        public abstract void SetClock();
    }
}
