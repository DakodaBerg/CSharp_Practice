
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRental> rentables = new List<IRental>();
            List<IBuy> buys = new List<IBuy>();

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Kia Optima" };
            var book = new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 350 };
            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };

            rentables.Add(vehicle);
            rentables.Add(excavator);
            buys.Add(book);
            buys.Add(vehicle);

            Console.Write("Do you want to buy or rent: (buy or rent) ");
            string RentOrBuy = Console.ReadLine();

            if (RentOrBuy.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to rent this item (yes/no): ");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    Console.Write("Do you want to return this item (yes/no): ");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                foreach (var item in buys)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to buy this item (yes/no): ");
                    string wantToBuy = Console.ReadLine();

                    if (wantToBuy == "yes")
                    {
                        item.Buy();
                    }
                }
            }
            Console.WriteLine("We are done ");
            Console.ReadLine();
        }
    }

    public interface IRental : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }

    public interface IBuy : IInventoryItem
    {
        void Buy();
    }

    public interface IInventoryItem
    {
        string ProductName { get; set; }
        int QuantityInStock { get; set; }
    }

    public class InventoryItemModel : IInventoryItem
    {
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }
    }

    public class VehicleModel : InventoryItemModel, IBuy, IRental
    {
        public decimal DealerFee { get; set; }

        public void Buy()
        {
            QuantityInStock--;
            Console.WriteLine("This vehicle has been sold");
        }

        public void Rent()
        {
            QuantityInStock--;
            Console.WriteLine("This vehicle has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock++;
            Console.WriteLine("This vehicle has been returned");
        }
    }

    public class BookModel : InventoryItemModel, IBuy
    {
        public int NumberOfPages { get; set; }

        public void Buy()
        {
            QuantityInStock--;
            Console.WriteLine("The Book has been sold");
        }
    }

    public class ExcavatorModel : InventoryItemModel, IRental
    {
        public void Dig()
        {
            Console.WriteLine("I am Digging");
        }

        public void Rent()
        {
            QuantityInStock--;
            Console.WriteLine("This excavtor has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock++;
            Console.WriteLine("This excavtor has been returned");

        }
    }
}
