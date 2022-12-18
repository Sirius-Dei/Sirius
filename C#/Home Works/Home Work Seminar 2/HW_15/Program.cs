System.Console.WriteLine("Введите число от 1 до 7");
int i = int.Parse(Console.ReadLine());
switch (i)
{
    case 1: System.Console.Write("Понедельник"); break;
    case 2: System.Console.Write("Вторник"); break;
    case 3: System.Console.Write("Среда"); break;
    case 4: System.Console.Write("Четверг"); break;
    case 5: System.Console.Write("Пятница"); break;
    case 6: System.Console.Write("Суббота"); break;
    case 7: System.Console.Write("Воскресенье"); break;
    default: System.Console.WriteLine("Это не день недели!"); break;
}
if (i == 6)
{
    System.Console.WriteLine(", наконец то выходной!");
}
else if (i == 7)
{
    System.Console.WriteLine(", хоть и выходной, но завтра на работу :(");
}