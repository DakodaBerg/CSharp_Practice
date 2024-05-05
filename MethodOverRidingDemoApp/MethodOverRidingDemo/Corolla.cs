using System;

namespace MethodOverRidingDemo
{
    public class Corolla : Car
    {
        public override void SetClock()
        {
            Console.WriteLine("twist nob");
        }
    }
}
