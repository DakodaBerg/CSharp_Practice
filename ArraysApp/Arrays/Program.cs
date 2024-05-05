


string data = "Tim,Sue,Bob,Jane,Frank";

// single quote identifies a char
// double quote identifies a string

string[] firstNames = data.Split(',');

Console.WriteLine(firstNames[1]);

Console.WriteLine(firstNames.Length);


string[] lastNames = new string[] { "Berg", "Smith", "Hill" };

int[] ages = new int[] {2,3,4,5 };
double[] tempsOutside = new double[] {99, 99.3, 32.1 };
decimal[] moneySpent = new decimal[] { 300M, 3230.32M, 23000.99M, 99.99M};


// array's are 0-based counting
// 0-based counting - 0,1,2,3,4 = 5
// 1 based counting - 1,2,3,4,5 = 5

//string[] firstNames = new string[5];


//firstNames[0] = "Dakoda";
//firstNames[1] = "Koda";
//firstNames[2] = "Tim";
////can skip if needed
//firstNames[4] = "Jane";

//Console.WriteLine($"The first names are " +
//    $"{firstNames[0]}, " +
//    $"{firstNames[1]}, " +
//    $"{firstNames[2]}, " +
//    $"{firstNames[4]}.");


//firstNames[0] = "timmy";

//firstNames[4] = "rob";
//Console.WriteLine(firstNames[5]);

