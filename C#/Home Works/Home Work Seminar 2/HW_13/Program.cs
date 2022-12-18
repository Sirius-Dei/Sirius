Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
string strText = Convert.ToString(num);
if (strText.Length > 2)
{
    Console.WriteLine("третья цифра -> " + strText[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}