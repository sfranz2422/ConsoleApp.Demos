Console.WriteLine("Methods");


void PrintSomething()
{
    Console.WriteLine("Something");
}

PrintSomething();

int GetFiveYearsAgo()
{
    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}



//parameters
void PrintNameWithParameters(string name)
{
    Console.WriteLine(name);
}

PrintNameWithParameters("steve");


int GetFutureOrPastYear(int numberOfYears = 0)
{
    var year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;

}

Console.WriteLine(GetFutureOrPastYear());


//nullable parameters
void PrintNameNullableParam(string? name, int? count = 0)
{
    //if (string.IsNullOrEmpty(name))
    //{
    //    name = "Default name";
    //}

    //the line below is the same as the above
    name ??= "Default name";


    if (!count.HasValue)
    {
        count = 1;
    }
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(name);
    }
}

PrintNameNullableParam("steve", 5);
PrintNameNullableParam(null,null);
