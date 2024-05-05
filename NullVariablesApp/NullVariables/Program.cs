

// null - lack of value


// Haven't asked for age yet
// ? allows for it to be null
int? age = null;
bool? birthday = null;
double? gender = null;
decimal? price = null;
string? firstName = null;


Console.WriteLine(age);
Console.WriteLine(birthday);
Console.WriteLine(gender);
Console.WriteLine(price);
Console.WriteLine(firstName);

// We have asked for the age now
age = 0;
birthday = false;
gender = 1.2;
price = 89.0190190M;
firstName = "Dakoda";


Console.WriteLine(age);
Console.WriteLine(birthday);
Console.WriteLine(gender);
Console.WriteLine(price);
Console.WriteLine(firstName);

