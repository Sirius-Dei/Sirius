int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine()!);
}

double pow(int numA, int numB)
{
    double res = Math.Pow(numA, numB);
    return res;
}


System.Console.WriteLine("Введите число А");
int A = ReadInt("Num A");
System.Console.WriteLine("Введите число B");
int B = ReadInt("Num B");
System.Console.WriteLine(pow(A, B));

