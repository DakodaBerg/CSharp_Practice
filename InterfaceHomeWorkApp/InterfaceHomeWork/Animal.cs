using System;

namespace InterfaceHomeWork
{
    public class Animal : IRun
    {
        public void Run()
        {
            Console.WriteLine("The Animal is running");
        }

        public void StopRunning()
        {
            Console.WriteLine("The Animal has stopped running");
        }
    }
}
