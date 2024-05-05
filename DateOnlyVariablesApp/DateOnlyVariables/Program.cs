




DateTime today = DateTime.Now;


DateOnly birthday = DateOnly.Parse("10/15/1997");


Console.WriteLine(birthday.ToString(format:"MM/dd/yy"));


// has the date and time
Console.WriteLine(value: $"Today full format: {today}");

// has the date and time is set to 12:00
Console.WriteLine(value: $"Today just date: {today.Date}");

// just has the date
Console.WriteLine(value: $"Birthday full format: {birthday}");

Console.WriteLine($"birthday full: {birthday}");


