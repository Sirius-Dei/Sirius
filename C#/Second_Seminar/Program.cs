﻿int GetNumber(int value)
{
    int a = value / 100;
    int b = (value / 10) % 10;
    int c = value % 10;
    return b * 10 + c;
}

int getNumberFromUser()
{
    int temp = int.Parse(Console.ReadLine());

    return temp;
}