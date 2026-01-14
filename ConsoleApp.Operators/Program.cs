// See https://aka.ms/new-console-template for more information


Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int sum = num1 + num2;
int product = num1 * num2;
int difference = num1 - num2;
int quotient = num1 / num2;
int remainder = num1 % num2;


Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Remainder: {remainder}");
