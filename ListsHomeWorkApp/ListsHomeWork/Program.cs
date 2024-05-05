//HomeWork
//Add students to a class roster List
//until there are no more students.
//Then print out the count of the students to the console.

List<string> classRoster = new List<string>();

//Console.Write("Will you like to add a Students name to the roster? (Yes/No): ");
//string? yesOrNo = Console.ReadLine();

//if (yesOrNo.ToLower() == "no")
//{
//    Console.WriteLine($"There are {classRoster.Count} students added to the roster");
//}
//else
//{
//    Console.WriteLine("Please enter the name of the student you want to add: ");
//    string? newStudent = Console.ReadLine();
//    classRoster.Add(newStudent);
//    Console.WriteLine($"{classRoster.Count}");
//}


do
{
    Console.Write("Will you like to add a Students name to the roster? (Yes/No/Exit): ");
    string? yesOrNo = Console.ReadLine();

    if (yesOrNo.ToLower() == "exit")
    {
        break;
    }
    if (yesOrNo.ToLower() == "no")
    {
        Console.WriteLine($"There are {classRoster.Count} students added to the roster");
    }
    else
    {
        Console.WriteLine("Please enter the name of the student you want to add: ");
        string? newStudent = Console.ReadLine();
        classRoster.Add(newStudent);
        Console.WriteLine($"{classRoster.Count}");
    }


} while (true);