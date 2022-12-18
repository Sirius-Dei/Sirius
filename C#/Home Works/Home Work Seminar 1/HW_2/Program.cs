//Напишите программу, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньше.

System.Console.WriteLine("Enter first number ");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter second number ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    System.Console.WriteLine($"{a} больше чем {b}");
}
else
{
    System.Console.WriteLine($"{b} больше чем {a}");
}