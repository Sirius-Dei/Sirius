double[] GetRandomArray(int length, int minValue, int maxValue)
{
    double[] array = new double[length];

    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(minValue, maxValue + 1);
    }
    return array;
}

double[] array = GetRandomArray(5, 1, 100);
double min = array[0];
double max = array[0];
FindMax(array);
FindMin(array);
FindDiff(max, min);

void FindDiff(double max, double min)
{
    double res = max - min;
    System.Console.WriteLine($"Разница между {max} и {min} = {res}");

}
double FindMax(double[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        if (array[index] > max)
        {
            max = array[index];
            index++;
        }
        else
        {
            index++;
        }

    }
    return max;
}
double FindMin(double[] array)
{
    int index = 0;
    while (index < array.Length)
    {

        if (array[index] <= min)
        {
            min = array[index];
            index++;
        }
        else
        {
            index++;
        }
    }
    return min;
}


