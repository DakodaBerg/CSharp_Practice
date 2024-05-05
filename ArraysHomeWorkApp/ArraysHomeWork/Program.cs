
//HomeWork
//create an array of 3 names.
//ask the user which number to select.
//when the user gives you a number, return that name.
//make sure to check for invalid numbers.

string[] firstNames = new string[] { "Dakoda", "John", "Mehagan" };

//Console.Write("Please select a number from 1 to 3 (1,2,3): ");

//string? selectNumberText = Console.ReadLine();

//bool isValidInt = int.TryParse(selectNumberText, out int selectedNumber);

//if ((selectedNumber == 1) || 
//    (selectedNumber == 2) ||
//    (selectedNumber == 3))
//{
//    Console.WriteLine($"The name you picked was {firstNames[selectedNumber - 1]}");
//}
//else
//{
//    Console.WriteLine("That was a invalid number");
//}

//string? selectNumberText;
//do
//{
//    Console.Write("Please select a number from 1 to 3 (1,2,3): ");

//    selectNumberText = Console.ReadLine();
//    bool isValidInt = int.TryParse(selectNumberText, out int selectedNumber);


//    if ((selectedNumber == 1) ||
//        (selectedNumber == 2) ||
//        (selectedNumber == 3))
//    {
//        Console.WriteLine($"The name you picked was {firstNames[selectedNumber - 1]}");
//    }
//    else
//    {
//        Console.WriteLine("That was a invalid number");
//    }

//} while ((selectNumberText != "1") ||
//         (selectNumberText != "2") ||
//         (selectNumberText != "3")
//);

string? selectNumberText;


do
{

    Console.Write("Please select a number from 1 to 3 (1,2,3): ");
    selectNumberText = Console.ReadLine();

    bool isValidInt = int.TryParse(selectNumberText, out int selectedNumber);

    if ((selectedNumber == 1) ||
        (selectedNumber == 2) ||
        (selectedNumber == 3))
    {
        Console.WriteLine($"The name you picked was {firstNames[selectedNumber - 1]}");
        break;
    }
    if ((selectedNumber < 1) || (selectedNumber > 3))
    {
        Console.WriteLine("That was a invalid number");
    }

} while (true);