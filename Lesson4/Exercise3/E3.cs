int[] numbers = new int[12];
int temp;
Random random = new Random();
Console.Write("Array random numbers :");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1, 25);
    Console.Write("{0} ", numbers[i]);
}
Console.WriteLine();
Console.Write("Bubble sort :");

for (int i = 0; i < numbers.Length; i++)
{
    for(int j = 0; j < numbers.Length-1-i; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            temp = numbers[j];
            numbers[j]= numbers[j + 1];
            numbers[j+1]= temp;
        }
    }
}
for (int i = 0;i< numbers.Length; i++)
{
    Console.Write("{0} ", numbers[i]);
}