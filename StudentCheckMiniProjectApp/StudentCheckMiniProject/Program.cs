// Plan and build a console application
// that asks a user for their name and their age.
// if their name is bob or sue, address them as professor.
// if the person is under 21, recommend they wait x years to start this class.


string firstName;
Console.Write(" What is your name: ");
firstName = Console.ReadLine();

int age;
Console.Write(" What is your age: ");
age = int.Parse(s: Console.ReadLine());
int yearsToWait = 21 - age;

// testing code so far and it works
//Console.WriteLine(firstName);
//Console.WriteLine(age);

if (firstName.ToLower() == "bob" ||
    firstName.ToLower() == "sue")
{
    Console.WriteLine("Hello Professor!");
}
else if (age <=20)
{
    Console.WriteLine($"Hello {firstName}!");
    Console.WriteLine($"We Recommed you wait {yearsToWait} years to start this class.");
}
else
{
    Console.WriteLine($"Hello, {firstName}!");
}


// first try at it

//int yearsToWait = 21 - age;

//if (age <= 20 && firstName.ToLower() != "bob" ||
//    firstName.ToLower() != "sue")
//{
//    Console.WriteLine($"We Recommed you wait {yearsToWait} years to start this class.");
//}
