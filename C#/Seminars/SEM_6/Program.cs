//Программа которая принимает три числа и проверяет может ли существовать треугольник со сторонами такой длинны.
//!!!Сумма двух сторон всегда больше третьей стороны!!!

//Как перевести десятичное число в двоичное



int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}

//void task1()
//{
//    System.Console.WriteLine("Введите сторону А");
//    int a = ReadInt("Сторона А");
//    System.Console.WriteLine("Введите сторону B");
//    int b = ReadInt("Сторона B");
//    System.Console.WriteLine("Введите сторону C");
//    int c = ReadInt("Сторона C");
//    Check(a, b, c);
//}

//void Check(int a, int b, int c)
//{
//    if (a + b > c && b + c > a && a + c > b) System.Console.WriteLine("Может существовать");
//    else System.Console.WriteLine("Не может существовать");
//}

//void task2()
//{
//    System.Console.WriteLine("Введите число");
//    int number = ReadInt("Number");
//    Convert(number);
//}

//void Convert(int num)
//{
//    string result = string.Empty;
//    while (num != 0)
//    {
//        result += num % 2;
//        num /= 2;
//    }
//    System.Console.WriteLine(result);
//}


void Fibonacci()
{
    int length = ReadInt("До какого числа Фибоначчи показать массив?");
    double[] array = new double[length];
    array[0] = 0;
    array[1] = 1;
    System.Console.WriteLine($"{array[0]} {array[1]} ");
    for (int i = 2; i < length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
        System.Console.WriteLine($"{array[i]} ");
    }

}



//task1();

//task2();

Fibonacci();
Console.ReadKey();
