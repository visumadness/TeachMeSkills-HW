Console.Write("Введите номер месяца (1-12): ");
string strMonth = Console.ReadLine();
bool tryMonth = int.TryParse(strMonth, out int numMonth);
Action<string> userOutput = Console.WriteLine;

if (numMonth == 12 || numMonth == 1 || numMonth == 2)
{
    userOutput("Это Зима");
    return;
}

if (numMonth >= 3 && numMonth <= 5)
{
    userOutput("Это Весна");
    return;
}

if (numMonth >= 6 && numMonth <= 8)
{
    userOutput("Это Лето");
    return;
}

if (numMonth >= 9 && numMonth <= 11)
{
    userOutput("Это Осень");
    return;
}

userOutput("Вы ввели не существующий номер месяца");
