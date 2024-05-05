
string firstName = "sue";
int age = 25;

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine(" you are a child");
        break;
    case >= 18 and < 66:
        Console.WriteLine("you should have a job");
        break;
    case >= 66:
        Console.WriteLine("hopefully you are retired!");
        break;
    default:
        Console.WriteLine("Age was not in an expected range.");
        break;

}






switch (firstName.ToLower())
{
    //will say hello dakoda when sue or dakoda.
    case "dakoda" or "sue":
        Console.WriteLine("Hello Dakoda!");
        break;
    case "tom":
        Console.WriteLine("Hello Tom!");
        break;
    default:
        Console.WriteLine("I don't know you.");
        break;
}




