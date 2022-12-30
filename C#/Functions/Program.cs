//int ReadInt(string argumentName)
//{
//    Console.Write($"Input {argumentName}: ");
//    return int.Parse(Console.ReadLine());
//}

//int[] GetArray(int length)
//{
//    int[] array = new int[length];
//
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = ReadInt($"elemtn {i}");
//    }
//
//    return array;
//}

//int[] GetRandomArray(int length, int min, int max)
//{
//    int[] array = new int[length];
//    Random rand = new Random();
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = rand.Next(min, max);
//    }
//
//    return array;
//}

//void PrintArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        System.Console.Write($"{array[i]}, ");
//    }
//}

//void reverse(int res)
//{
//    for (int i = 0; i < res.Length / 2; i++)
//    {
//        int temp = res[i];
//        res[i] = res[res.Length - 1 - i];
//        res[res.Length - 1 - i] = temp;
//    }
//}

//void CopyArray(int[] FirstArray)
//{
//
//    for (int i = 0; i < FirstArray.Length; i++)
//    {
//        SecondArray[i] = FirstArray[i];
//    }
//}

//int[] BubbleSort(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        for (int j = 0; j < array.Length - 1 - i; j++)
//        {
//            if (array[j] < array[j + 1])
//            {
//                int temp = array[j];
//                array[j] = array[j + 1];
//                array[j + 1] = temp;
//            }
//        }
//    }
//    return array;
//}
// int GetSumRow(int[,] array, int i)
// {
//     int tempSum = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         tempSum += array[i, j];
//     }
//     return tempSum;
// }

// int SumNumbers(int number)                 //RECURSION
// {
//     if (number / 10 == 0)
//     {
//         return number % 10;
//     }
//     return number % 10 + SumNumbers(number / 10);
// }

// System.Console.WriteLine(SumNumbers(121233));