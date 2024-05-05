


Console.Write("what is your age: ");

string? ageText = Console.ReadLine();

// taking what the user typed into the console 
// and making it a string and not a number
// so when you do ageText + 15 it won't add them together
// so if ageText was 15 and we run it we would get 1515
//Console.WriteLine(ageText + 15);

// here we are making the ageText a int
// so when we run age + 15 we actully add the age
// so if ageText was 15, then we would get 30


//int age = int.Parse(ageText);

// caused a crash when trying edge cases
// entered an age of "four"
// Now using TryParse
// Tryparse works with bool
// out int age returns a int age
bool isValidInt = int.TryParse(ageText, out int age);

Console.WriteLine($"This is valid: {isValidInt}. The number was {age}.");


//Console.WriteLine(age + 15 );

// works because we aint losing in info
// int can go into a double
double testDouble = age;

//casting a double to a decimal
decimal testDecimal = (decimal)testDouble;

