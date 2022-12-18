System.Console.WriteLine("Enter first number ");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter second number ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    System.Console.WriteLine($"{a} больше {b}");
}
else
{
    System.Console.WriteLine($"{b} больше {a}");
}