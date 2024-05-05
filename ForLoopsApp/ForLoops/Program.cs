

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"The value of i is {i}");
//}


//string data = "dakoda,ryan,john,bob,sue";
//List<string> firstName = data.Split(',').ToList();

//for (int i = 0; i < firstName.Count; i++)
//{
//    Console.WriteLine($"{firstName[i]} is a student");
//}

List<decimal> charges = new();

charges.Add(23.78M);
charges.Add(42343245.3424M);
charges.Add(32M);

decimal total = 0;

for (int i = 0; i < charges.Count; i++)
{
    total += charges[i];
}

Console.WriteLine($"Are total charge is ${total}");
