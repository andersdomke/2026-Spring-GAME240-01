bool quitting = false;
bool success = true;

while (quitting == false || success == true)
{
    Console.WriteLine("This calculator can perform 5 operations: addition, subtraction, multiplication, division, and modulus.\nType your operations now. 'Quit' to end.");
    string input = (Console.ReadLine());
    string[] inputSplit = input.Split(' ');

    success = double.TryParse(inputSplit[0], out double num1);
    success = double.TryParse(inputSplit[2], out double num2);

    string quitLower = inputSplit[0].ToLower();
    if (quitLower == "quit")
    {
        quitting = true;
    }
    else if (inputSplit[1] == "+")
    {
        double result = num1 + num2;
        Console.WriteLine(num1 + " + " + num2 + " = " + result);
    }
    else if (inputSplit[1] == "-")
    {
        double result = num1 - num2;
        Console.WriteLine(num1 + " - " + num2 + " = " + result);
    }
    else if (inputSplit[1] == "*")
    {
        double result = num1 * num2;
        Console.WriteLine(num1 + " * " + num2 + " = " + result);
    }
    else if (inputSplit[1] == "/")
    {
        double result = num1 / num2;
        Console.WriteLine(num1 + " / " + num2 + " = " + result);
    }
    else if (inputSplit[1] == "%")
    {
        double result = num1 % num2;
        Console.WriteLine(num1 + " % " + num2 + " = " + result);
    }
    else
    {
        Console.WriteLine("I do not know how to do that.");
    }
}

if (success == false)
{
    Console.WriteLine("ERROR, input not recognized");
}