
using Methods;
using System.Threading.Channels;


//for (int i = 0; i < 10; i++)
//{
//    SampleMethods.SayHi();
//}

// DRY - Don't Repeat Yourself
// SOLID - S = SRP - Single Responsibility Principle
//       - O = OCP - Open-closed Principle
//       - L = LSP - Liskov substitution principle
//       - I = ISP - Interface segregation principle
//       - D = DIP - Dependency inversion principle


//Console.Write("What is your name: ");
//string name = Console.ReadLine();

//string name = ConsoleMessages.GetUsersName();


//ConsoleMessages.SayHi(name);

//double result = MathShortCuts.Add(5, 3);
//Console.WriteLine($"The result is {result}");

//double[] vals = new double[] { 2, 5, 6, 21, 52, 98 };
//MathShortCuts.AddAll(vals);


//ConsoleMessages.SayGoodBye();

var fullName = ConsoleMessages.GetFullName();

Console.WriteLine($"First Name: {fullName.Item1.ToUpper()}");
Console.WriteLine($"Last Name: {fullName.Item2.ToUpper()}");


string ageText = "43";
bool isValid = int.TryParse(ageText, out int age);







