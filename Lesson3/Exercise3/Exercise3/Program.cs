Console.Write("Введите число: ");
string strNum = Console.ReadLine();
bool isInteger = int.TryParse(strNum, out int numValue);

if (isInteger)
{
    numValue %= 2;

    if (numValue == 0)
    {
        Console.WriteLine("Четное число");
        return;
    }

    Console.WriteLine("Нечетное число");
    return;
}

Console.WriteLine("Вы ввели неприемлемое значение");
