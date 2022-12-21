// Первая группа методов - Ничего не принимают, ничего не возвращают. VOID (Ничего не возвращает)
//void Met1()
//{
//    System.Console.WriteLine("Метод 1");
//}
//Met1();



//Вторая группа методов - Ничего не возвращают, но могут принимать какие либо аргументы. VOID (Ничего не возвращает)
//void Met2(string msg)
//{
//    System.Console.WriteLine(msg);
//}
//Met2("Метод 2");

//void Met2_1(string str, int index)
//{
//   int i = 0;
//    while (i <= index)
//    {
//        System.Console.WriteLine(str);
//        i++;
//    }
//}
//Met2_1(index: 0, str: "Метод 3"); //Явно указываем какому аргументу что присваиваем. В таком случае их не обязательно писать по порядку



//Третья группа методов - Методо который что то возвращает
//int Met3()
//{
//    return DateTime.Now.Year;
//}
//int year = Met3();
//System.Console.WriteLine(year);



// Четвёртая (самая важная) группа методов - Что то принимает и что то возвращает.
//string Met4(int count, string text)
//{
//    int i = 0;
//    string result = String.Empty;
//    while (i < count)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}
//string res = Met4(1, "Метод 4");
//System.Console.WriteLine(res);


// ЦИКЛ for
//string Met4(int count, string text)
//{
//    string result = String.Empty;
//    for (int i = 0; i < count; i++)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}
//string res = Met4(1, "Метод 4");
//System.Console.WriteLine(res);

//Двойной цикл for
//for (int i = 2; i < 10; i++)
//{
//    for (int j = 2; j < 10; j++)
//    {
//        System.Console.WriteLine($"{i} * {j} = {i * j}");
//    }
//    System.Console.WriteLine();
//}

// Задача по изменению текста
//string s = "qwerty"
// s[3] // r

//string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//            + "ежели бы вас послали вместо нашего милого Винценгероде,"
//            + "вы бы взяли приступом согласие прусского короля. "
//            + "Вы так красноречивы. Вы дадите мне чаю?";
//
//
//string Replace(string text, char oldValue, char newValue)
//{
//    string result = String.Empty;
//    int length = text.Length;
//    for (int i = 0; i < length; i++)
//    {
//        if (text[i] == oldValue) result = result + $"{newValue}";
//        else result = result + $"{text[i]}";
//    }
//
//    return result;
//}
//string newText = Replace(text, ' ', '|');
//
//System.Console.WriteLine(newText);
//System.Console.WriteLine();
//newText = Replace(newText, 'к', 'К');
//System.Console.WriteLine(newText);


//Алгорритм выбором//Сортировка//Пузырьковая сортировка

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }

}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);