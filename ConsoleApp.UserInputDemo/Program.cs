
// Declare Variables
string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;
decimal salary = 0;
char gender = char.MinValue;
bool isWorking = true;



// Prompt user for input
Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

string fullName = firstName + " " + lastName;

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: ");
salary = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (true or false): ");
isWorking = Convert.ToBoolean(Console.ReadLine());



// process the data
int workingYearsRemaining = retirementAge - age;

Console.WriteLine($"Full name: {fullName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your Salary: {salary}");
Console.WriteLine($"Your Gender: {gender}");
Console.WriteLine($"Working: {isWorking}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");



