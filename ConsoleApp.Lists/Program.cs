//declare a list


List <string> myList = new List<string>();
//var grades = new List<string>();
//List<int> grades = new();

List<int> grades = new List<int>();
int grade = 0;




myList.Add("steve");

do
{
    Console.WriteLine("Enter a grade: ");
    grade = Convert.ToInt32(Console.ReadLine());
    grades.Add(grade);


} while (grade != -1);

foreach(int g in grades)
{
    Console.WriteLine($"{g}");
}
