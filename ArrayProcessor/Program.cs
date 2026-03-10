using System;

int[] numbers = { 10, 25, 7, 42, 18, 33 };

Console.Write("배열 :");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]}");
    if (i < numbers.Length -1 )
    {
        Console.Write(", ");
    }
}

Console.WriteLine();
static int ProcessArray(int[] data, Func<int[], int> processor)
{
    return processor(data);
}




int sum = ProcessArray(numbers, arr =>
{
    int total = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        total += arr[i];
    }
    return total;
});
Console.WriteLine($"합계 : {sum}");

int max = ProcessArray(numbers, arr =>
{
    int maxValue = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxValue)
        maxValue = arr[i];
    }
    return maxValue;
});
Console.WriteLine($"최댓값: {max}");

int min = ProcessArray(numbers, arr =>
{
    int minValue = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minValue)
        {
            minValue = arr[i];
        }
    }
    return minValue;
});
Console.WriteLine($"최솟값 : {min}");


int countEven = ProcessArray(numbers, arr =>
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
});
Console.WriteLine($"짝수 개수 : {countEven}");

