Console.Write("How many times would you like to print \"Hello World\": ");
int lineNumber = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < lineNumber; i++)
{
    Console.WriteLine($"Hello World! {i}");
}


int counter = 10;


while (counter > 0)
{
    Console.WriteLine($"Counter: {counter}");
    counter--;
}


Console.WriteLine("Enter numbers to be summed:");
int sum = 0;
int num = 0;
while (num != -1)
{

    num = Convert.ToInt32(Console.ReadLine());
    if (num != -1)
    {
        sum += num;
    }
}
Console.WriteLine($"The sum is {sum}");



