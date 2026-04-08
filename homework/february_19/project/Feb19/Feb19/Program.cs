Console.WriteLine("This calculator can perform 4 operations: addition, subtraction, multiplication, and division.\n\nWhat operation would you like to perform?");
string input = (Console.ReadLine());
Console.WriteLine("What is your first number?");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("What is your second number?");
double num2 = double.Parse(Console.ReadLine());

if (input == "addition")
{
    double result = num1 + num2;
    Console.WriteLine(num1 + " + " + num2 + " = " + result);
}
else if (input == "subtraction")
{
    double result = num1 - num2;
    Console.WriteLine(num1 + " - " + num2 + " = " + result);
}
else if (input == "multiplication")
{
    double result = num1 * num2;
    Console.WriteLine(num1 + " * " + num2 + " = " + result);
}
else if (input == "division")
{
    double result = num1 / num2;
    Console.WriteLine(num1 + " / " + num2 + " = " + result);
}
else
{
    Console.WriteLine("I do not know how to do that.");
}