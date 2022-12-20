System.Console.WriteLine("Введите X для А");
int ax = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Y для А");
int ay = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Z для А");
int az = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите X для B");
int bx = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Y для B");
int by = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Z для B");
int bz = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
System.Console.WriteLine("Расстояние между точками 'A,B' в 3D пространстве = " + Math.Round(d, 2));