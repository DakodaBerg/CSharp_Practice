

using System.Globalization;

DateTime today = DateTime.Now;

//DateTime birthday = DateTime.Parse(s: "10/15/1997");

DateTime birthday = DateTime.ParseExact("10/15/1997", "M/d/yyyy", CultureInfo.InvariantCulture);


//Console.WriteLine(today.ToString(format:"T"));

//Console.WriteLine(birthday);

Console.WriteLine(today.ToString(format: "MMMM dd, yyyy hh:mm K tt zzz")); 