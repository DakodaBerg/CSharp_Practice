
//HomeWork
//Ask the user for a conmma-separated list of first names(no spaces).
//Split the string into string array.
//Loop through the array and print "Hello <name>" to the console for each person.

Console.WriteLine("Please enter a list of first names(conmma-separated & no spaces):");
string data = Console.ReadLine();
string[] firstNames = data.Split(",".ToArray());


for (int i = 0; i < firstNames.Length; i++)
{
    Console.WriteLine($"Hello {firstNames[i]}");
}

