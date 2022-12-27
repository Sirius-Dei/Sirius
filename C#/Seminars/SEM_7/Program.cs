int[,] array = GetArray(ReadInt("strings"), ReadInt("columns"));
PrintArray(array);
System.Console.WriteLine();
DiagonalSum(array);


int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}

int[,] GetArray(int length, int secondLength)
{
    int[,] array = new int[length, secondLength];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Random rand = new Random();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(5, 10);

        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }

}

void DiagonalSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += array[i, j];
            }
        }
    }
    System.Console.WriteLine(sum);
}
