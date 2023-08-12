Action<string> userOutput = Console.WriteLine;
char again = 'y';
while (again == 'y')
{
    double a;
    double b;
    double total;
    char oper;

    Console.Write("Enter the first number:");
    a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter operator:");
    oper = Convert.ToChar(Console.ReadLine());

    Console.Write("Enter the second number:");
    b = Convert.ToDouble(Console.ReadLine());

    if (oper == '+')
    {
        total = a + b;
        Console.WriteLine("Sum " + a + " + " + b + " = " + total);
    }
    else if (oper == '-')
    {
        total = a - b;
        Console.WriteLine("Difference " + a + " - " + b + " = " + total);
    }
    else if (oper == '*')
    {
        total = a * b;
        Console.WriteLine("Multiplication " + a + " * " + b + " = " + total);
    }
    else if (oper == '/')
    {
        total = a / b;
        Console.WriteLine("Division " + a + " / " + b + " = " + total);
    }
    else
    {
        userOutput("Unknown operator.");
    }

    userOutput("Do you want to continue working with the calculator? (y/n)");
    again = Convert.ToChar(Console.ReadLine());   
}
