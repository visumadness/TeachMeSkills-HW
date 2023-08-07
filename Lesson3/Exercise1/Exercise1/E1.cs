Console.Write("Введите номер месяца (1-12): ");
string strMonth = Console.ReadLine();
bool tryMonth = int.TryParse(strMonth, out int numMonth);
Action<string> userOutput = Console.WriteLine;

switch (numMonth)
{
    case 12:
    case 1:
    case 2:
        userOutput("Это зима");
        break;
    case 3:
    case 4:
    case 5:
        userOutput("Это Весна");
        break;
    case 6: 
    case 7:
    case 8:
        userOutput("Это Лето");
        break;
    case 9:
    case 10:
    case 11:
        userOutput("Это Осень");
        break;
    default:
        userOutput("Вы ввели не существующий номер месяца");
        break;
}