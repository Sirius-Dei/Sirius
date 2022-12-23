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
    System.Console.WriteLine("Сумма элементов стоящих на нечетных позициях из массива:");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"Равняется ");
}




int length = ReadInt("length");
int[] array = GetRandomArray(length, 1, 99);
PrintArray(array);
getSum(array);



void getSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < length; i += 2)
    {
        sum += array[i];
    }
    System.Console.Write($"'{sum}'");
}