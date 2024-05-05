
//HomeWork
//Create a Dictionary list of employee ID's and the name that goes with the ID.
//Fill in a few records.
//Then ask the user for their ID and return their name.
//Use string for ID

Dictionary<int, string> employees = new Dictionary<int, string>();

employees[1] = "Dakoda";
employees[2] = "John";


//Console.Write("What is your employee ID number: ");
//string? consoleResponse = Console.ReadLine();
//Console.WriteLine($"Your name is {employees[consoleResponse]}.");

//Ask user if they want to add employee(yes/no/done)
//After adding new employee show all ID's and Names of all employees
//If no then ask user for their employee ID


Console.Write("Will you like to add an employee?(yes/no):");
string addEmployee = Console.ReadLine();

while (addEmployee.ToLower() == "yes")
{
    Console.Write("What is the new employees name?(type \"exit\" to quit): ");
    string newName = Console.ReadLine();
    if (newName == "exit")
    {
        Console.Write("Will you like to add an employee?(yes/no):");
        addEmployee = Console.ReadLine();

    }
    else
    {
        employees.Add(employees.Count + 1, newName);
        Console.WriteLine("Current employee list");
        foreach (var pair in employees)
        {
            Console.WriteLine($"Employee ID = {pair.Key} Name = {pair.Value} ");
        }

    }
}
if (addEmployee.ToLower() == "no")
{

    Console.Write("What is your employee ID number: ");
    string enteredIdText = Console.ReadLine();
    bool isValidInt = int.TryParse(enteredIdText, out int employeeId);
    Console.WriteLine($"Hello {employees[employeeId]}");
}