bool keepGoing = true;

while (keepGoing == true)
{

    Console.WriteLine("Welcome to the sample calculator");



    Console.Write("Please enter the first number or type \"exit\" to exit: ");
    string ans = Console.ReadLine();


    if (ans == "exit")
    {
        keepGoing = false;
        break;
    }

    int num1 = Convert.ToInt32(ans);



    Console.Write("Please enter the second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("What operation would you like to perform? (+,-,*,/,fib)\n \"fib\" will give the nth digit of the fibonacci sequence to the second number: ");
    string operation = Console.ReadLine();

    int answer = 0;
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

        case "fib":
            int a = 1;
            int b = 1;

            for (int i = 0; i < (num2 - 2); i++)
            {
                answer = a + b;
                if (i % 2 == 0)
                {
                    a = answer;
                }
                else
                {
                    b = answer;
                }


            }
            break;
        default:
            Console.WriteLine("Invalid Input");
            break;

    }
    if (operation != "fib")
    {
        Console.WriteLine($"{num1} {operation} {num2} = {answer}");

    }
    else
    {
        Console.WriteLine($"The {num2}th digit of the fib sequence is {answer}");

    }
}

