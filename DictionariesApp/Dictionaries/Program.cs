

Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["animal"] = "Not a human";
lookup["fish"] = "Not a human that swims";
lookup["human"] = "Us";

Console.WriteLine($"The definitiion of fish is {lookup["fish"]}");

Dictionary<int, string> employees = new Dictionary<int, string>();

employees[1] = "Dakoda Berg";
employees[2] = "John Berg";
employees[44321] = "Tim Corey";

Console.WriteLine($"The employee with ID number 2 is {employees[2]}");

Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

dayOfWeek["Wednesday"] = 4;
dayOfWeek["Thursday"] = 5;
dayOfWeek["Friday"] = 6;

Console.WriteLine($"Wednesday is day number { dayOfWeek["Wednesday"]}");