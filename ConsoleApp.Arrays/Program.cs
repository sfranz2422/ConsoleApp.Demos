
//this is an array
int[] grades = new int[5];
//now i need 5 elements

grades[0] = 10;


Console.WriteLine(grades.ToString());

for (int i = 0; i<grades.Length; i++)
{
    Console.WriteLine("Enter a Grade: ");
    int grade = Convert.ToInt32(Console.ReadLine());
    grades[i] = grade;
}
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);

}

// variable size array
string[] studentNames = { "steve", "mel", "luca", "gia" };
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine("Enter a name: ");
    string name = Console.ReadLine();
    studentNames[i] = name;
}
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);

}
