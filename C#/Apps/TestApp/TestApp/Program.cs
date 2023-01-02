int[] array = GetArray(ReadAndCheck("length"));
PrintArray(array);
int i = 0;
while (i > 0)
    i++;
System.Console.WriteLine(i);
#region Functions
int[] GetArray(int length)
{
    Random r = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = r.Next(-10, 10);
    }
    return array;
}
int ReadAndCheck(string arg)
{
    int length = 0;
    Console.WriteLine($"Input {arg}");
    try
    {
        length = int.Parse(Console.ReadLine()!);
    }
    catch
    {
        Console.WriteLine("Введённый символ не является числом!");
    }
    return length;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
#endregion