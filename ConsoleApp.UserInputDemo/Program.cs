
// Declare Variables
string name = string.Empty;
int age = 0;
int retirementAge = 65;


// Prompt user for input
Console.WriteLine("Please enter you name:");
name = Console.ReadLine();

Console.WriteLine("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

// process the data
int workingYearsRemaining = retirementAge - age;

Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");


