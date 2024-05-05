

// capture a users age from the console and
// then identify how old they will be in 25 years,
// as well as how old they were 25 years ago.
// print that info to the console in natural language


Console.WriteLine("Greeting! Will you like for me to tell you how old you'll be in 25 years");
Console.Write("Please enter your current age: ");
string? currentAge = Console.ReadLine();


// saves the users age into one variable
// also stops from crashing if invalid age is enter in console.
// but if invalid age is enter it defaults age to 0.
bool? isValidInt = int.TryParse(currentAge, out int age);

// why save the user age into two different variable?
// just save user age in one variable

//int futureAge = int.Parse(currentAge);
//int pastAge = int.Parse(currentAge);


Console.WriteLine($"Great! In 25 years, you'll be {age + 25}!");
Console.WriteLine($"Also 25 years ago you would have been {age - 25}!");




