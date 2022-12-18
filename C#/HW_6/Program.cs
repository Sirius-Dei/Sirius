Console.WriteLine("Enter the number");
int n = int.Parse(Console.ReadLine());
int r = (n % 2);
if (r == 0) System.Console.WriteLine($"Number {n} is even!");
else System.Console.WriteLine($"Number {n} is odd!");