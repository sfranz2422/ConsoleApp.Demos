// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");


// differnt datatypes
/*

text - string
integers - int
decimal - double, float, decimal
logical - bool

 
 
 */

string state = "Ohio";

Console.WriteLine(state);
//string interpolation
Console.WriteLine($"I am from {state}, blah");
Console.WriteLine("I am from " + state + " blah");
Console.WriteLine("I am from {0}, blah", state);

int age = 47;
int retirementAge = 65;
int retirementYearsLeft = retirementAge - age;

Console.WriteLine("My age is: " + age);

bool isRetired  = false;
