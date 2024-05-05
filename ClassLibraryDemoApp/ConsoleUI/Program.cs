
using CoreLibrary;

class Program
{
    private static void Main(string[] args)
    {
        Generators generators = new Generators();
        PersonModel person = new PersonModel()
        {
            Prefix = "Mr.",
            FirstName = "Dakoda",
            LastName = "Berg"
        };

        string message = generators.WelcomeMessage(person.Prefix, person.LastName);

        Console.WriteLine(message);


        Console.ReadLine();
    }
}