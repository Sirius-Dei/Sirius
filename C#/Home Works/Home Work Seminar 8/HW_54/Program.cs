int[,] array = Get2DemArr(ReadInt("row length"), ReadInt("columns length"));
SortNumbersInARows(array);
int i = 0;
while (i > 0)
    i++;
System.Console.WriteLine(i);
Console.ReadKey();

void SortNumbersInARows(int[,] array)
{
    System.Console.Write("Input array:");
    Print2DemArray(array);
    System.Console.WriteLine();

    int[] getRow = GetRow(array, 0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        getRow = GetRow(array, i);
        Sort(getRow);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = getRow[j];
        }
    }
    System.Console.Write("Sorted array: ");
    Print2DemArray(array);
}
int[] GetRow(int[,] array, int rowNumber)
{
    int[] tempArray = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        tempArray[i] = array[rowNumber, i];
    }

    return tempArray;
}
int[] Sort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j] < array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}
int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
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
    System.Console.WriteLine();
}