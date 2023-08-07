Console.Write("Введите температуру:");
var temp = Console.ReadLine();
Action<string> userOutput = Console.WriteLine;

if (int.TryParse(temp, out int numTemp))
{
    if (numTemp > -5)
    {
        userOutput("Тепло");
        return;
    }
    if (numTemp >= -20)
    {
        userOutput("Нормально");
        return;
    }
    if (numTemp <= -21)
    {
        userOutput("Холодно");
        return;
    }

}

userOutput("Вы ввели неверное или несуществующее значение");
