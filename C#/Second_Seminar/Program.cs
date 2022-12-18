int GetNumber(int value)
{
    int a = value / 100;
    int b = (value / 10) % 10;
    int c = value % 10;
    return b * 10 + c;
}

int getNumberFromUser()
{
    System.Console.WriteLine("Введи трёхзначное число от 100 до 999");
    int temp = int.Parse(Console.ReadLine());

    return temp;
}

bool validator(int number)
{
    return number >= 100 && number <= 999;
    //    if (number >= 100)
    //   {
    //        if (number <= 999)
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
}

string GetText(int input, int output)
{
    return input + "->" + output;
}

string Decorator(string text)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    return text;
}

void Task36()
{
    int value = getNumberFromUser();
    if (validator(value))
    {
        int result = GetNumber(value);
        System.Console.WriteLine(Decorator(GetText(value, result)));
    }
    else
    {
        System.Console.WriteLine("WRONG NUMBER!");
    }
}





