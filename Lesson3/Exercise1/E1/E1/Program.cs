// See https://aka.ms/new-console-template for more information
Console.Write("Введите номер месяца (1-12): ");
int month = int.Parse(Console.ReadLine());
switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Это Зима");
        break;

    case 3:
    case 4:
    case 5:
        Console.WriteLine("Это Весна");
        break;

    case 6: 
    case 7:
    case 8:
        Console.WriteLine("Это Лето");
        break;

    case 9:
    case 10:
    case 11:
        Console.WriteLine("Это Осень");
        break;
    default:
        Console.WriteLine("Вы ввели не существующий номер месяца");
        break;

}