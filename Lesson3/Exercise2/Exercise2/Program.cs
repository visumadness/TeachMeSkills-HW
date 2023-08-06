// See https://aka.ms/new-console-template for more information
Console.Write("Введите номер месяца (1-12): ");
int month = int.Parse(Console.ReadLine());

if (month == 12 || month == 1 || month == 2)
{
    Console.WriteLine("Это Зима");
    return;
}

if (month >= 3 && month <= 5)
{
    Console.WriteLine("Это Весна");
    return;
}

if (month >= 6 && month <= 8)
{
    Console.WriteLine("Это Лето");
    return;
}

if (month >= 9 && month <= 11)
{
    Console.WriteLine("Это Осень");
    return;
}

Console.WriteLine("Вы ввели не существующий номер месяца");
