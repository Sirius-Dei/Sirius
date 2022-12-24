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