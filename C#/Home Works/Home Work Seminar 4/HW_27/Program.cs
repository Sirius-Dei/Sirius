int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine()!);
}

System.Console.WriteLine("Input number");
string n = ReadInt("Number").ToString();
int size = n.Length;
int sum = 0;
for (int i = 0; i < size; i++)
{
    sum = n[0] + n[1];
}
System.Console.WriteLine(sum);
