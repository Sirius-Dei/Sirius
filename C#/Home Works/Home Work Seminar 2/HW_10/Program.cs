//Ввод данных 
int Enter()
{
    System.Console.WriteLine("Введи трёхзначное число от 100 до 999");
    int value = int.Parse(Console.ReadLine());
    return value;
}

//Метод получения второй цифры числа
int GetSecondNumber(int value)
{
    int a = value / 100;
    int b = (value / 10) % 10;
    int c = value % 10;
    return b;
}

//Метод отсеивания неправильных чисел
bool valid(int validNums)
{
    return validNums >= 100 && validNums <= 999;
}

int value = Enter();
if (valid(value))
{
    int result = GetSecondNumber(value);
    System.Console.WriteLine($"Вторая цифра числа {value} -> {result} !");
}
else
{
    System.Console.WriteLine("Введите корректное число!");
}