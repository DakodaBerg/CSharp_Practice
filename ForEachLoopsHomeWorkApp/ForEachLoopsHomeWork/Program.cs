
//HomeWork
//Ask the user for their first name.
//Continue asking for first names until there are no more.
//Then loop through each name using foreach and tell person hello on the console.

List<string> firstNames = new();

Console.Write("Would you like to add a name?(yes/no):");
string yesOrNo = Console.ReadLine();


do
{
    Console.Write("Please enter first name: ");
    string nameData = Console.ReadLine();
    firstNames.Add(nameData);

    Console.Write("Would you like to add another name?(yes/no): ");
    string addMoreNames = Console.ReadLine();

    if (addMoreNames.ToLower() == "no")
    {

        foreach (string name in firstNames)
        {
            Console.WriteLine($"Hello {name}");
        }

        yesOrNo = "no";

    }
} while (yesOrNo == "yes");