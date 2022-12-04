// Welcome User to App
using System.Net.Security;

Console.WriteLine("Welcome to the greeting Application.");
Console.WriteLine("This application is build by Naomi Perenboom.");
Console.WriteLine();

// Ask for Names
Console.Write("What is your first name: ");
string firstName;
firstName = Console.ReadLine();

Console.Write("I would also like to know your last name: ");
string lastName;
lastName = Console.ReadLine();
Console.WriteLine();

// Greet user by name
Console.WriteLine("Hello " + firstName + " " + lastName + "!!");
Console.WriteLine("Thank you for using this Application.");
Console.WriteLine();

//Ask for age
Console.Write("What is your age: ");
string age;
age = Console.ReadLine();
Console.WriteLine();

// Ask for a kiss
Console.Write("Now, you will have to kiss the maker of this Application the number of your age given (: ");
Console.WriteLine( age);
Console.WriteLine();
