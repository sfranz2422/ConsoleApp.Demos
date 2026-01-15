Console.WriteLine("What is your age? ");
while (true)
{
    try
    {
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Your age is {age}");
        break;

    }
    catch (Exception)
    {
        Console.WriteLine("Please enter a number");
        //throw;
    }
    finally
    {
        Console.WriteLine("Thank you!");
    }
    
}




