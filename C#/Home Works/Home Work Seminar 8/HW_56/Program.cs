int[,] array = Get2DemArr(4, 4);
Print2DemArray(array);

void CalculateRows(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length)
}


int[] GetFirstRow(int[,] array)
{
    int rowNumber = 2;
    int[] tempArray = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        tempArray[i] = array[rowNumber, i];
    }

    return tempArray;
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