System.Console.WriteLine("Введите номер четверти");
int qwarter = int.Parse(Console.ReadLine());
if (qwarter >= 1 && qwarter <= 4)
{
    if (qwarter == 1)
    {
        System.Console.WriteLine($"X (1, {int.MaxValue}), Y (1, {int.MaxValue})");
    }
    if (qwarter == 2)
    {
        System.Console.WriteLine($"X (-1, {int.MinValue}), Y (1, {int.MaxValue})");
    }
    if (qwarter == 3)
    {
        System.Console.WriteLine($"X (-1, {int.MinValue}),Y (1, {int.MinValue})");
    }
    if (qwarter == 4)
    {
        System.Console.WriteLine($"X (1, {int.MaxValue}), Y (-1, {int.MinValue})");
    }
}
else System.Console.WriteLine("Неправильнный номер четверти!");
