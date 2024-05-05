
//HomeWork
//Create a console application that asks the user for their name.
// Welcome (Tim) as professor or anyone else as student.
// make sure that "TIM" also gets called as professor.

string? userName;

Console.Write("What is your name: ");
userName = Console.ReadLine();

//Completeing task with if/else if/ else

if (userName.ToLower() == null ||
    userName.ToLower() == "" ||
    userName.ToLower() == " ")
{
    Console.WriteLine("Invalid Name");

}
else if (userName.ToLower() == "tim" ||
         userName.ToLower() == "timmy")
{
    Console.WriteLine("Welcome Professor");
    
}
else
{
    Console.WriteLine("Welcome Student!");
}



// Completeing the task with using a switch

//switch (userName.ToLower())
//{
//    case "tim":
//        Console.WriteLine("Welcome Professor!");
//        break;
//    case null or "" or " ":
//        Console.WriteLine("Invalid Name");
//        break;
//    default:
//        Console.WriteLine("Welcome Student!");
//        break;
//}


