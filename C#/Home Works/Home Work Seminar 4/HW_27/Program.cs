//Это жесть конечно. Ещё не пробовал таким образом получать сумму чисел)

int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine()!);
}

System.Console.WriteLine("Input number");
int n = ReadInt("Number");
int sum = 0;
while (n > 0)
{
    sum += n % 10;
    n = n / 10;
}
System.Console.WriteLine(sum);


