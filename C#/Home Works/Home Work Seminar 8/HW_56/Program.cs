int[,] array = Get2DemArr(5, 5);
CalculateRows(array);

#region Methods
void CalculateRows(int[,] array)
{
    Print2DemArray(array);
    int minRow = 0;
    int min = GetSumRow(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = GetSumRow(array, i);
        if (sum < min)
        {
            min = sum;
            minRow = i;
        }
        if (i == array.GetLength(0) - 1 && i == array.GetLength(1) - 1) System.Console.WriteLine($"Min sum of elements on a {minRow + 1} row = {min}");
    }
}
int GetSumRow(int[,] array, int i)
{
    int tempSum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        tempSum += array[i, j];
    }
    return tempSum;
}
void Print2DemArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
    }
}
int[,] Get2DemArr(int rows, int columns)
{
    Random r = new Random();
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = r.Next(10);
        }
    }
    return array;
}
#endregion