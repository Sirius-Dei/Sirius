
int[,] array = GetArray(5, 5);
int Find = ReadInt("Find number");
int FindResult = 0;
PrintArray(array);
FindNumberInArray(array);
Check(FindResult);

int FindNumberInArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == Find)
            {
                FindResult = 1;
            }
        }
    }
    return FindResult;
}
void Check(int result)
{
    if (result == 1) System.Console.WriteLine($"Number {Find} found in array!");
    else System.Console.WriteLine($"Number {Find} not found in array...");
}
int ReadInt(string comments)
{
    System.Console.Write($"Input {comments}: ");
    return int.Parse(Console.ReadLine());
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}, ");
        }
        System.Console.WriteLine();
    }

}

