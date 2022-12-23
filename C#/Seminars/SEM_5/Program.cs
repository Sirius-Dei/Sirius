void taskXZ()
{
    System.Console.WriteLine("Введите длинну массива");
    int length = ReadInt("Length"); //123
    int[] array = GetRandomArray(length, 1, 1000);

    PrintArray(array);
    System.Console.WriteLine();
}


void elemInRange(int[] array)
{
    int elem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            elem++;
        }
    }
    System.Console.WriteLine(elem);
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
int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine()!);
}

