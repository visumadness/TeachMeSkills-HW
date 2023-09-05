using E1.Calculator;
using E1.Logger;
using E1.NewFolder;
using System.Net.WebSockets;

ConsoleKey oneMoreTime;
string resultValue = String.Empty;

do
{

    Console.WriteLine(MessageType.MessageStart);
    string inputString = Console.ReadLine();

    Console.WriteLine(
        OpertionCalculation(inputString, out var leftNumber, out var rightNumber, out var operation)
        ? $"={OperationsMenu(leftNumber, rightNumber, operation)}"
        : "Invlaid input");
    Console.WriteLine(resultValue);

    ILogger outputFileLogger = new FileLogger("calculatorLogger.txt");
    ILogger outputConsoleLogger = new ConsoleLogger();
    var outputCompositLogger = new ServiceLogger(new FileAndConsoleLogger(outputFileLogger, outputConsoleLogger));
    outputCompositLogger.LogAll(inputString, resultValue);

    Console.WriteLine(MessageType.MessageReplay);

    oneMoreTime = Console.ReadKey().Key;

    ILogger oneMoreTimeFileLogger = new FileLogger("calculatorLogger.txt");
    ILogger oneMoreTimeConsoleLogger = new ConsoleLogger();
    var oneMoreTimeCompositeLogger = new ServiceLogger(new FileAndConsoleLogger(outputFileLogger, outputConsoleLogger));
    outputCompositLogger.LogOneMore(oneMoreTime);
}
while (oneMoreTime != ConsoleKey.Escape);


static Operations SymbolOperation(char symbol) => symbol switch
{
    '+' => Operations.Summation,
    '-' => Operations.Subtraction,
    '*' => Operations.Multiplication,
    '/' => Operations.Division,
    _ => Operations.None
};

static double OperationsMenu(int firstNumber, int secondNumber, Operations operation) => operation switch
{
    Operations.Summation => firstNumber + secondNumber,
    Operations.Subtraction => firstNumber - secondNumber,
    Operations.Multiplication => firstNumber * secondNumber,
    Operations.Division => CalculateDivision(firstNumber, secondNumber),
    _ => double.NaN
};

static double CalculateDivision(int firstNumber, int secondNumber) => secondNumber == 0
        ? firstNumber > 0 ? double.PositiveInfinity : double.NegativeInfinity
        : (double)firstNumber / secondNumber;

static bool OpertionCalculation(string expression, out int leftNumber, out int rightNumber, out Operations operation)
{
    leftNumber = 0;
    rightNumber = 0;
    operation = 0;

    if (string.IsNullOrEmpty(expression))
    {
        return false;
    }

    var operationSymbols = new char[] { '+', '-', '*', '/' };

    var operationIndex = expression.IndexOfAny(operationSymbols);
    if (operationIndex == -1)
    {
        return false;
    }

    var inputs = expression.Split(operationSymbols);
    if (inputs.Length != 2
       || !int.TryParse(inputs[0], out leftNumber)
       || !int.TryParse(inputs[1], out rightNumber))
    {
        return false;
    }

    operation = SymbolOperation(expression[operationIndex]);
    return true;
}