
// Home Work
// Creat a Welcome method,
// a method to ask for the user's name,
// and another to tell that user "Hello <name>".
// Call these methods from Program.cs


using MethodsHomeWork;

ConsoleGreetings.WelcomeUser();

(string firstName, string lastName) = ConsoleGreetings.AskForUsersName();

ConsoleGreetings.CallUserByName(firstName, lastName);
