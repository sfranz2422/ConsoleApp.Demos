Console.WriteLine("Date Time Manipulation");




//Empty DateTime Object
DateTime date = new DateTime();

var dateOfBirth = new DateTime(1978,6,29);
Console.WriteLine($"my dob is: {dateOfBirth}");


var exactDateOfBirth = new DateTime(1980, 12, 29,1,0,25,DateTimeKind.Local);
Console.WriteLine($"my dob is: {exactDateOfBirth}");


Console.WriteLine($"Day of Week: {dateOfBirth.DayOfWeek}");
Console.WriteLine($"Day of Year: {dateOfBirth.DayOfYear}");
Console.WriteLine($"Time of Day: {exactDateOfBirth.TimeOfDay}");
Console.WriteLine($"Tick: {dateOfBirth.Ticks}");
Console.WriteLine($"Kind: {exactDateOfBirth.Kind}");

//get current timestamp
DateTime now = DateTime.Now;
Console.WriteLine(now);


//create from a string
//Console.WriteLine("What is your dob? (MM/dd/yyyy) ");
//string dob = Console.ReadLine();

//var userDob = DateTime.Parse(dob);
//Console.WriteLine($"Day of Week: {userDob.DayOfWeek}");
//Console.WriteLine($"Day of Year: {userDob.DayOfYear}");
//Console.WriteLine($"Time of Day: {userDob.TimeOfDay}");
//Console.WriteLine($"Tick: {userDob.Ticks}");
//Console.WriteLine($"Kind: {userDob.Kind}");



Console.WriteLine($"\n\n\nFormatted Date: {now.ToString("MMMM  dd, yyyy")}");


// time math
Console.WriteLine(now.AddDays(1));


//UTC tiime or greenwich mean time
var utcNow = DateTime.UtcNow;
Console.WriteLine(utcNow);


var tz = TimeZoneInfo.Local.GetUtcOffset (utcNow);

Console.WriteLine(tz.ToString());

var dto = new DateTimeOffset(now, tz);
Console.WriteLine(dto.ToString());

Console.WriteLine($"UTC time of action: {dto.UtcDateTime}");


var indiaTZ = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTZ);
Console.WriteLine($"Action was complted in India at {indiaDateTime}");


//Date Only
var dateOnly = new DateOnly(1978,6,29);
Console.WriteLine(dateOnly.ToString());


// date comparison
var date1 = new DateTime(1985, 11, 23);
var date2 = new DateTime(1985, 11, 23);

if (date1 == date2)
{
    Console.WriteLine("The dates are equal");
}


if (date1.Equals(date2))
{
    Console.WriteLine("equal");
}

//can also use inequalities









