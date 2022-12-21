int[] GetArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt("Number");
    }
    return array;

}
string ArrayToString(int[] array)
{
    string result = string.Empty;

    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]}, ";
    }
    return result;
}
int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine()!);
}

int[] arr = GetArray(8);
string res = ArrayToString(arr);
System.Console.Write(res);