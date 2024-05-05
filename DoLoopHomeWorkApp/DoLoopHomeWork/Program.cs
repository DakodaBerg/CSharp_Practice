//HomeWork
//create a console application
//that asks the user for their name
//welcome me (Tim) as professor or any one else as student
//do this until the user types "exit.


string? firstName;

do
{
    Console.WriteLine("Enter your name or type exit to quit");
    Console.Write("What is your name: ");
    firstName = Console.ReadLine();


    if (firstName.ToLower() == "tim")
    {
        Console.WriteLine("Hello Professor Tim!");
    }
    else if (firstName.ToLower() != "exit")
    {
        Console.WriteLine($"Hello student {firstName}");
    }

} while (firstName.ToLower() != "exit");




//string? firstName = "";


//while (firstName.ToLower() != "exit")
//{


//    Console.WriteLine("Enter your name or type exit to quit");
//    Console.Write("What is your name: ");
//    firstName = Console.ReadLine();


//    if (firstName.ToLower() == "tim")
//    {
//        Console.WriteLine("Hello Professor Tim!");
//    }
//    else if (firstName.ToLower() != "exit")
//    {
//        Console.WriteLine($"Hello student {firstName}");
//    }

//}
