Action<string> exerciseNumber = Console.WriteLine;

////////////////////////////////////////////////////////////////////////

exerciseNumber("1.1");
Console.WriteLine("Maximum array element" + "\n");
int[] array = { 92, 35, 47, 86, 144 };
Array.Sort(array);
int maxValue = array[array.Length - 1];
Console.WriteLine($"Max Value = {maxValue.ToString()}");
Console.WriteLine(" ");//indent from the task

////////////////////////////////////////////////////////////////////////

exerciseNumber("1.2");
Console.WriteLine("Arithmetic mean of all elements of jagged array"+"\n");
Console.Write("Random :");
Random random = new Random();

int[][] arrayZub = new int[5][];
int sum = 0;
double average;
int m = 0;

for (int i = 0; i < arrayZub.Length; i++)
{
    arrayZub[i] = new int[i + 1];

    for (int j = 0; j < i + 1; j++)
    {
        m++;
        arrayZub[i][j] = random.Next(5, 15);
        sum += arrayZub[i][j];
        Console.Write("{0} ", arrayZub[i][j]);
    }
}
Console.WriteLine("\n"+$"Array Sum = {sum}");
Console.WriteLine($"Array length = {m}");
average = (double)sum / m;
Console.WriteLine($"Arithmetic mean = {average}");
Console.WriteLine(" ");//indent from the task

////////////////////////////////////////////////////////////////////////

exerciseNumber("1.3");
Console.WriteLine("Algorithm for compiling an array of the first n numbers of the Fibonacci sequence" + "\n");
int[] Fib(int number)
{
    int[] a = new int[number];
    a[0] = 0;
    a[1] = 1;
    for (int i = 2; i < number; i++)
    {
        a[i] = a[i - 2] + a[i - 1];
    }
    return a;
    {

    }
}
var b = Fib(10);
foreach(var elements in b)
{
    Console.Write("{0} ", elements);
}
Console.WriteLine(" ");//indent from the task