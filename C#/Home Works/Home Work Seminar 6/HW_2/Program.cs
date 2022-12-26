//P.S Я не шарю в этих пересечениях точек, поэтому способ нахождения X,Y нашел в интернете. 
//Следовательно можете мне смело занизить оценку или балл, не знаю как тут.

int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}

double b1 = ReadInt("b1");
double k1 = ReadInt("k1");
double b2 = ReadInt("b2");
double k2 = ReadInt("k2");
ITR(b1, k1, b2, k2);

void ITR(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    if (k1 == k2 && b1 == b2) System.Console.WriteLine("Lines coincide");
    else if (k1 == k2) System.Console.WriteLine(" lines are parallel");
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    }
    System.Console.WriteLine($"{x} {y}");
}