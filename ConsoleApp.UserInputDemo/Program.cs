
// Declare Variables
using System.Xml.Linq;

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;


// Prompt user for input
Console.WriteLine("Please enter your first name:");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name:");
lastName = Console.ReadLine();

string fullName = firstName + " " + lastName;

Console.WriteLine("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

// process the data
int workingYearsRemaining = retirementAge - age;

Console.WriteLine($"Full name: {fullName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");


