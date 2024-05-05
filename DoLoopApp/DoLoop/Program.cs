
bool isValidAge;
int age;
//int testNumber = 0;



//Console.Write("What is your age: ");
//string? ageText = Console.ReadLine();

//bool isValid = int.TryParse(ageText, out int age);


//while (age < 21)
//{
//    Console.WriteLine("Your not old enought to buy beer!");
//    return;
//}

//Console.WriteLine("Your old enought to buy beer!");

//if (age < 21)
//{
//    Console.WriteLine("Your not old enough to buy beer");
//}
//else
//{
//    Console.WriteLine("You can buy beer!");
//}


//do
//{
//    Console.WriteLine(testNumber);
//    testNumber += 3;
//} while (testNumber < 10);


// runs the code at least 1 time
//do
//{

//} while (true);


// runs the code 0 or more times
//while (true)
//{

//}


do
{
    Console.Write("What is your age: ");
    string? ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out age);

    if (isValidAge == false)
    {
        Console.WriteLine("That was an invalid age.");

    }
} while (isValidAge == false);


Console.WriteLine($"your age is {age}");





