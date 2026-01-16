
Console.WriteLine("String Manipulation");


string s1 = "This is a string literal";

//not preferred
String s2 = "this is a string literal";

// default value is null
string s3;

//makes it nullable.  compiler will warn us a little more later on
string? s4 = null;


//this is better than
string s5 = string.Empty;

//this...this will not throw a null exception
string s6 = " ";

// escape character \ 
string sentence = "She said \"lasdjjasflf\"";
string path = "C:\\program files\\programfolder\\";

// verbatim string
string newPath = @"C:\program files\programfolder\";

//const
const string newPath2 = @"C:\program files\programfolder\";
//newPath2 = "sadf";


//raw string literal new with C# 11  triple quotes have to start and end on their own line
string rawLiteral = """

    This is a literal string "she said I have your phone"



    """;

//s1 = s1 + s2;
//s1 += s2;

string newString = $"{s1} {s2} some other string";




//name of method will print name of variable "s1"
Console.WriteLine($"{nameof(s1)}: {s1}");






// string manipulation methods
// find the length of a string
Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");


//this will cause an exception
//Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");


// check if null


if (!string.IsNullOrEmpty(s4))
{
    Console.WriteLine($"{nameof(s4)}Is Not Null");
}
else
{
    Console.WriteLine("s4 is null");
}


// substring
string subString = s1.Substring(0, s1.Length);
Console.WriteLine($"\n\n\n\n{subString}");

var splitStrings = s2.Split(' ');
Console.WriteLine(splitStrings);

for (int i = 0; i < splitStrings.Length; i++)
{
    Console.WriteLine(splitStrings[i]);
}

string replacements = s1.Replace('s', 'V');
Console.WriteLine(replacements);

//will make it into currency
string salary = 982734973249.44645.ToString("C");

int value = 898798;
string strValue = value.ToString();

bool someBool = false;

string boolString = someBool.ToString();


// string formatter
//Console.WriteLine($"$Salary: {salary:C}");
Console.WriteLine($"Salary: {value:C}");


