Console.Clear();
Console.Write("Введите 3-значное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num <100) | (num > 999))
{
    Console.WriteLine("Число не 3-значное");
}
else
{
    int num2 = num / 10 % 10;
    Console.WriteLine(num2);
}