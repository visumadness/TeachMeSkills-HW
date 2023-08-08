Console.Write("Введите число: ");
string strNum = Console.ReadLine();

if (int.TryParse(strNum, out int numValue))
{

    if (numValue % 2 == 0)
    {
        Console.WriteLine("Четное число");
        return;
    }

    Console.WriteLine("Нечетное число");
    return;
}

Console.WriteLine("Вы ввели неприемлемое значение");
