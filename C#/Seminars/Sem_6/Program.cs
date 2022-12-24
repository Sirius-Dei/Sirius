//Программа которая принимает три числа и проверяет может ли существовать треугольник со сторонами такой длинны.
//!!!Сумма двух сторон всегда больше третьей стороны!!!

//Как перевести десятичное число в двоичное



int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}

void task1()
{
    System.Console.WriteLine("Введите сторону А");
    int a = ReadInt("Сторона А");
    System.Console.WriteLine("Введите сторону B");
    int b = ReadInt("Сторона B");
    System.Console.WriteLine("Введите сторону C");
    int c = ReadInt("Сторона C");
    Check(a, b, c);
}

void Check(int a, int b, int c)
{
    if (a + b > c && b + c > a && a + c > b) System.Console.WriteLine("Может существовать");
    else System.Console.WriteLine("Не может существовать");
}

void task2()
{
    System.Console.WriteLine("Введите число");
    int number = ReadInt("Number");
    Convert(number);
}

void Convert(int num)
{
    string result = string.Empty;
    while (num != 0)
    {
        result += num % 2;
        num /= 2;
    }
    System.Console.WriteLine(result);
}

string Reverse(string res)
{
    string result = string.Empty;
    char[] array = result.Reverse().ToArray();
    foreach (char c in array)
    {
        result += c;
    }
    return result;
    System.Console.WriteLine(Reverse(result));
}

void Fibonacci()
{
    int length = ReadInt("До какого числа Фибоначчи показать массив?");
    int[] array = new int[length];
    array[0] = 0;
    array[1] = 1;
    System.Console.Write($"{array[0]} {array[1]} ");
    for (int i = 2; i < length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
        System.Console.Write($"{array[i]} ");
    }

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}

int[] GetRandomArray(int length)
{
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 100);
    }

    return array;
}

void Task3()
{
    //Создать копию массива с поэлементным копированием

    System.Console.WriteLine("Задайте количество элементов массива");

    int[] FirstArray = GetRandomArray(ReadInt("massive length"));
    PrintArray(FirstArray);
    int[] SecondArray = new int[FirstArray.Length];
    CopyArray(FirstArray);
    System.Console.WriteLine();
    PrintArray(SecondArray);

}

void CopyArray(int[] FirstArray)
{

    for (int i = 0; i < FirstArray.Length; i++)
    {
        SecondArray[i] = FirstArray[i];
    }
}


