using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    // Interface is a contract
    // Classes implement interfaces


    internal class Program
    {
        static void Main(string[] args)
        {
            List<IComputerController> controllers = new List<IComputerController>();
            BatteryPoweredGameController battery = new BatteryPoweredGameController();


            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();
            BatteryPoweredKeyboard keyboardController = new BatteryPoweredKeyboard();

            controllers.Add(gameController);
            controllers.Add(keyboard);
            controllers.Add(battery);

            foreach (var controller in controllers)
            {

            }

            List<IBatterPower> powereds = new List<IBatterPower>();

            powereds.Add(battery);
            

            Console.ReadLine();
        }
    }

    public interface IComputerController
    {
        void Connect();
        void CurrentKeyPressed();
    }

    public interface IBatterPower
    {
        int BatteryLevel { get; set; }
    }

    public class Keyboard : IComputerController
    {
        public void Connect()
        {

        }

        public void CurrentKeyPressed()
        {

        }

        public string ConnectionType { get; set; }
    }

    public class BatteryPoweredKeyboard : Keyboard, IBatterPower
    {
        public int BatteryLevel { get; set; }
    }

    public class GameController : IComputerController, IDisposable
    {
        public void Connect()
        {

        }

        public void CurrentKeyPressed()
        {

        }

        public void Dispose()
        {
            // do whatever shutdown task needed
        }

    }

    public class BatteryPoweredGameController : GameController, IBatterPower
    {
        public int BatteryLevel { get; set; }
    }
}
