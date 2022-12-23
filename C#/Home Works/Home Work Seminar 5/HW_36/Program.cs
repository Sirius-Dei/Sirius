int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine()!);
}
int[] GetArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt("Number");
    }
    return array;
}


