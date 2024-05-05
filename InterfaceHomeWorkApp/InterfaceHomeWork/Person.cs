using System;

namespace InterfaceHomeWork
{
    public class Person : IRun
    {
        public void Run()
        {
            Console.WriteLine("You are running");
        }

        public void StopRunning()
        {
            Console.WriteLine("You have stopped running");
        }
    }
}
