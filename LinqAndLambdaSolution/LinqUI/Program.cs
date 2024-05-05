using System;
using System.Linq;

namespace LinqUI
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static void LambdaTests()
        {
            var data = SampleData.GetContactData();

            var results = data.Where(x => x.Addresses.Count > 1);
        }
    }
}
