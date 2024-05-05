

List<string> firstNames = new List<string>();

firstNames.Add("Dakoda");
firstNames.Add("John");
firstNames.Add("Megan");
firstNames.Add("Tim");
firstNames.Add("Ryan");
firstNames.Add("Frank");

Console.WriteLine(firstNames[firstNames.Count - 1]);


List<int> ages = new List<int>();
ages.Add(1);
ages.Add(2);
ages.Add(3);
ages.Add(4);

// List<T> - T is a generic can pick the Type

string data = "berg,hill,smith";
List<string> lastNames = data.Split(',').ToList();
lastNames.Add("wong");