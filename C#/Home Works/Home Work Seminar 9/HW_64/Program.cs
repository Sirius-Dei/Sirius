Recursion(5, 1);
void Recursion(int m, int n)
{
    if (m <= n)
    {
        System.Console.WriteLine(m);
        return;
    }
    System.Console.Write($"{m}, ");
    Recursion(m - 1, n);
}

AltRecursion(5);
void AltRecursion(int m)
{
    if (m <= 1)
    {
        System.Console.WriteLine(m);
        return;
    }
    System.Console.Write($"{m}, ");
    AltRecursion(m - 1);
}






