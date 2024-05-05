


//TimeOnly opensAt = TimeOnly.Parse("8:00 AM");
using System.Globalization;

TimeOnly opensAt = TimeOnly.Parse(s:"8:00 AM");
TimeOnly now = TimeOnly.FromDateTime(DateTime.Now);



Console.WriteLine(opensAt);

// to format the time date ToString(format: " add how you want it formatted"));
Console.WriteLine(now.ToString(format:"hh"));
Console.WriteLine(timeOfBirth);






