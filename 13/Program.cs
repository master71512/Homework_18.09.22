Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("3-й цифры нет");
}
else
{
    int num3 = -1;
    while (num >= 100)
    {
        num3 = num % 10;
        num = num / 10;
    }
    Console.WriteLine(num3);
}