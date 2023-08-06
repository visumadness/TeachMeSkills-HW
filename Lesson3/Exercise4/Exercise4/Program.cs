// See https://aka.ms/new-console-template for more information
Console.Write("Введите температуру:");
var temp = Convert.ToInt32(Console.ReadLine());

if (temp > -5)
{
    Console.WriteLine("Тепло");
    return;
}

if (temp >= -20) 
{
    Console.WriteLine("Нормально");
    return;
}

if (temp <= -21)
{
    Console.WriteLine("Холодно");
    return;
}

Console.WriteLine("Вы ввели неверное или несуществующее значение");
