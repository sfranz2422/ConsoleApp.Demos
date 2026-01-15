using System.Net.Http.Headers;

Console.Write("Please enter student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

if (grade >= 90)
{
    Console.WriteLine("Student's grade is A");
}
else if (grade >= 80)
{
    Console.WriteLine("Student's grade is B");
}
else if (grade >= 70)
{
    Console.WriteLine("Student's grade is C");
}
else if (grade >= 60)
{
    Console.WriteLine("Student's grade is D");
}
else
{
    Console.WriteLine("Student's grade is F");
}

string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine(passStatus);

Console.Write("Enter a number (1-7) to get the corresponding day of the week: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;



}
