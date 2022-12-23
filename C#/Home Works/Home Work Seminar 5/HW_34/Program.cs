int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine()!);
}
int[] GetRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}


int length = ReadInt("Length");
int[] array = GetRandomArray(length, 100, 1000);
PrintArray(array);
System.Console.Write("- Массив");
System.Console.WriteLine();
System.Console.Write(even(array));
System.Console.Write(" - Колличество чётных чисел в массиве");




int even(int[] nums)
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (nums[i] % 2 == 0)
            count++;
    }
    return count;
}


