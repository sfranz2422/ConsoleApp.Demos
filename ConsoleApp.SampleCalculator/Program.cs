Console.WriteLine("Welcome to the sample calculator");



Console.Write("Please enter the first number: ");
decimal num1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter the secone number: ");
decimal num2 = Convert.ToDecimal(Console.ReadLine());

Console.Write("What operation would you like to perform? (+,-,*,/): ");
string operation = Console.ReadLine();

decimal answer = 0;
switch (operation)
{
    case "+":
        answer = num1 + num2;
        break;

    case "-":
        answer = num1 - num2;
        break;

    case "*":
        answer = num1 * num2;
        break;

    case "/":
        answer = num1 / num2;
        break;

    default:
        Console.WriteLine("Invalid Input");
        break;

}

Console.WriteLine($"{num1} {operation} {num2} = {answer}");

