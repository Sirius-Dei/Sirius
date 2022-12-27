int ReadInt(string comments)
{
    System.Console.Write($"Input {comments}: ");
    return int.Parse(Console.ReadLine());
}
double[,] GetDoubleArray(int strings, int columns)
{
    Random rand = new Random();
    double[,] array = new double[strings, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-10, 10);
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}, ");
        }
    }
}

double[,] array = GetDoubleArray(ReadInt("Strings"), ReadInt("Columns"));
PrintArray(array);

