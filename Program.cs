while (true)
{
    Console.Write("Enter first number (or 'exit' to quit): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    if (!double.TryParse(input, out double num1))
    {
        Console.WriteLine("Invalid input. Numbers only.");
        continue;
    }

    Console.Write("Enter second number: ");
    string input2 = Console.ReadLine();


    if (!double.TryParse(input2, out double num2))
    {
        Console.WriteLine("Invalid input. Numbers only.");
        continue;
    }

    Console.Write("Enter operation (+, -, *, /): ");
    string operation = Console.ReadLine();

    double result = 0;

    if (operation == "+")
    {
        result = num1 + num2;
    }
    else if (operation == "-")
    {
        result = num1 - num2;
    }
    else if (operation == "*")
    {
        result = num1 * num2;
    }
    else if (operation == "/")
    {
        if (num2 == 0)
        {
            Console.WriteLine("Undefined\n");
            continue;
        }
        result = num1 / num2;
    }
    else
    {
        Console.WriteLine("Invalid operation. Choose only (+, -, *, /)!");
        continue;
    }

    Console.WriteLine($"Result: {result}\n");

}