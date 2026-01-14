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


