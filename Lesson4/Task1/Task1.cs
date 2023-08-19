var arrayForTest = new int[] { 12, 45, 64, 3, 0, 157 };
var expectedMax = arrayForTest.Max();
if (FindMaxValue(arrayForTest) == expectedMax)
{
    Console.WriteLine($"{nameof(FindMaxValue)} method works correctly");
}
///////////////////////////////////////////////////////////////

var zubArrayForTests = new int[][] {
    new int[] { 16, 24, 0, 9 },
    new int[] { 1, 2, 4, 4, 5, 3},
    new int[] { 1, 2, 5 },
    new int[] { 1, 18}
};
var expectedAvg = 2d;
if (CalculteAverageValue(zubArrayForTests) == expectedAvg)
{
    Console.WriteLine($"{nameof(CalculteAverageValue)} method works correctly");
}
/////////////////////////////////////////////////////////////

Console.WriteLine($"Fibonacci sequence: {string.Join(' ', GenerateFibonacciSequence(10))}");
///////////////////////////////////////////////////////////////

static int FindMaxValue(int[] array)
{
    if (array == null || array.Length == 0)
    {
        throw new ArgumentException($"Parameter \"{nameof(array)}\" is null or empty.");
    }

    var max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        max = array[i] > max ? array[i] : max;
    }
    return max;
}

static double CalculteAverageValue(int[][] array)
{
    if (array == null || array.Length == 0)
    {
        throw new ArgumentException($"Parameter \"{nameof(array)}\" is null or empty.");
    }

    var sum = 0d;
    var totalLength = 0;
    foreach (var subArray in array)
    {
        if (subArray == null)
        {
            continue;
        }

        totalLength += subArray.Length;
        foreach (var item in subArray)
        {
            sum += item;
        }
    }

    return sum / totalLength;
}

static int[] GenerateFibonacciSequence(int FibonacciSequence)
{
    const int fibonacciFirst = 0;
    const int fibonacciSecond = 1;

    if (FibonacciSequence < 0)
    {
        throw new ArgumentException($"Parameter \"{nameof(FibonacciSequence)}\" must be 0 or greater.");
    }

    if (FibonacciSequence == 0)
    {
        return Array.Empty<int>();
    }

    if (FibonacciSequence == 1)
    {
        return new int[] { fibonacciFirst };
    }

    var fibonacciNums = new int[FibonacciSequence];
    fibonacciNums[0] = fibonacciFirst;
    fibonacciNums[1] = fibonacciSecond;
    for (var i = 2; i < FibonacciSequence; i++)
    {
        fibonacciNums[i] = fibonacciNums[i - 1] + fibonacciNums[i - 2];
    }

    return fibonacciNums;
}
