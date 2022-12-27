int[,] array = GetArray(3, 4);
GetAverage(array);


void GetAverage(int[,] array)
{
    PrintArray(array);
    double sum = 0;
    for (int k = 0; k < array.GetLength(1); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == k)
                    sum += array[i, j];
            }
        }
        System.Console.WriteLine($"Average {k + 1} column - {Math.Round(sum / array.GetLength(0), 2)}");
        sum = 0;
    }
}
int[,] GetArray(int strings, int columns)
{
    Random rand = new Random();
    int[,] array = new int[strings, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}, ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}