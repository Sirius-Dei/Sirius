//Напишите программу которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

void FillArray(int[] arg)
{
    int length = arg.Length;
    int index = 0;
    while (index < length)
    {
        arg[index] = index + 1;
        index++;
    }
}

System.Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
FillArray(arr);


int r = (n % 2);
int size = arr.Length;
for (int i = 1; i < size; i++)
    if (r == 0) //Если чётное то
    {
        System.Console.Write($"{arr[i]}, ");
        i++;
    }
    else if (r != 0) // Если не чётное
    {
        Console.Write($"{arr[i]}, ");
        i++;
    }




