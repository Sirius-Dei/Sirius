int a = ReadInt("First matrix rows");
int b = ReadInt("First matrix columns and second matrix rows");
int c = ReadInt("Second matrix columns");

int[,] firstMatrix = Get2DemArr(a, b);
PrintArray(firstMatrix);

int[,] secondMatrix = Get2DemArr(b, c);
PrintArray(secondMatrix);

int[,] result = new int[a, c];

MatrixProduct(firstMatrix, secondMatrix, result);
PrintArray(result);

#region Methods
void MatrixProduct(int[,] firstMatrix, int[,] secondMatrix, int[,] result)
{
    int sum = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            result[i, j] = sum;
        }
    }
}
int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine()!);
}
int[,] Get2DemArr(int rows, int columns)
{
    Random r = new Random();
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = r.Next(1, 10);
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
}
#endregion