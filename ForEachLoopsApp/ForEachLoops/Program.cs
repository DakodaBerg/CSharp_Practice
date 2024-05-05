

string data = "dakoda,john,megan,ryan";
List<string> firstNames = data.Split(',').ToList();

foreach (string firstName in firstNames)
{

    Console.WriteLine(firstName);

}

