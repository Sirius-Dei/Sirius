int[] GetRandomArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max);
    }

    return array;
}
int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}
void СheckGreaterZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    PrintArray(array);
    System.Console.WriteLine();
    System.Console.WriteLine($"Numbers in the array is greater than zero = '{count}'");
}

int[] array = GetRandomArray(ReadInt("massive length"), ReadInt("massive from"), ReadInt("massive to"));
СheckGreaterZero(array);

