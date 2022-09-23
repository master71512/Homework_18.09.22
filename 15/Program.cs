Console.Clear();
Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num < 1) | (num > 7))
{
    Console.WriteLine("некорректный номер");
}
else
{
    if ((num == 6) | (num == 7))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}