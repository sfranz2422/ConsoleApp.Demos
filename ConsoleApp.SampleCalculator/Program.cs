/*
 SampleCalculator - Program.cs
 --------------------------------
 A simple console-based calculator demo. Repeatedly prompts the user for:
  1) A first integer (or the literal "exit" to quit the program)
  2) A second integer
  3) An operation to perform: +, -, *, /, or "fib"

 Behavior and notes:
 - Enter "exit" at the first-number prompt to terminate the program.
 - Input is read as strings and converted to integers using Convert.ToInt32.
   Invalid integer input will prompt the user to try again.
 - Supported operations:
     "+"   : addition (num1 + num2)
     "-"   : subtraction (num1 - num2)
     "*"   : multiplication (num1 * num2)
     "/"   : integer division (num1 / num2) - note: this performs integer division and will throw
             a DivideByZeroException if num2 is zero.
     "fib" : computes the num2-th Fibonacci number using an iterative approach starting with 1,1.
             The implementation assumes num2 >= 1; for num2 <= 2 the loop is skipped and the result is
             derived from the initial values. The algorithm uses two rolling variables `a` and `b`.
 - The program prints the result to the console. If an unrecognized operation is provided, "Invalid Input" is shown.
 - Known limitations:
     * Fibonacci implementation uses 32-bit integers and may overflow for large indices.
     * Input validation uses exceptions for control flow; acceptable for this demo but not ideal for production code.
*/

bool keepGoing = true;

while (keepGoing == true)
{
    // Greeting displayed each iteration
    Console.WriteLine("Welcome to the sample calculator");

    // Operands for arithmetic operations
    int num1 = 0;
    int num2 = 0;

    // Prompt user for the first number or "exit" to quit
    Console.Write("Please enter the first number or type \"exit\" to exit: ");

    // Loop until a valid integer is entered or the user types "exit"
    while (true)
    {
        string ans = Console.ReadLine();
        if (ans == "exit")
        {
            // User requested exit - mark flag and break out to outer loop
            keepGoing = false;
            break;
        }
        try
        {
            // Try to convert the input to an integer
            num1 = Convert.ToInt32(ans);
            break;
        }
        catch (Exception)
        {
            // Conversion failed - instruct the user and re-prompt
            {
                Console.WriteLine("Please enter a number, press enter to continue.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

    if (keepGoing == false)
    {
        // breaks from outer loop
        break;
    }

    // Prompt for the second number and validate similarly to the first
    Console.Write("Please enter the second number: ");
    while (true)
    {
        string ans = Console.ReadLine();
        try
        {
            num2 = Convert.ToInt32(ans);
            break;
        }
        catch (Exception)
        {
            {
                Console.WriteLine("Please enter a number, press enter to continue.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

    // Prompt for the desired operation; "fib" interprets num2 as the index in the sequence
    Console.Write("What operation would you like to perform? (+,-,*,/,fib)\n \"fib\" will give the nth digit of the fibonacci sequence to the second number: ");
    string operation = Console.ReadLine();

    int answer = 0;
    switch (operation)
    {
        case "+":
            // Addition
            answer = num1 + num2;
            break;

        case "-":
            // Subtraction
            answer = num1 - num2;
            break;

        case "*":
            // Multiplication
            answer = num1 * num2;
            break;

        case "/":
            // Integer division (will throw for division by zero)
            try
            {
                answer = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division by zero not allowed");
                break;
            }
            break;

        case "fib":
            // Compute the num2-th Fibonacci number using iteration.
            // Starting values are a = 1, b = 1 which correspond to Fib(1)=1, Fib(2)=1.
            // The loop runs (num2 - 2) times to advance the sequence.
            int a = 1;
            int b = 1;

            for (int i = 0; i < (num2 - 2); i++)
            {
                answer = a + b;
                // Alternate updating `a` and `b` to roll forward through the sequence.
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
            // Unrecognized operation
            Console.WriteLine("Invalid Input");
            break;
    }

    // Output formatting differs for arithmetic vs fibonacci result
    if (operation != "fib")
    {
        Console.WriteLine($"{num1} {operation} {num2} = {answer}");
    }
    else
    {
        Console.WriteLine($"The {num2}th digit of the fib sequence is {answer}");
    }
}

