Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num >= 0)
{
    Console.Write($"Кубы чисел от 1 до {num}: ");
for (int i = 1; i <= num; i++)
{
    int cube = i * i * i;
    Console.Write(cube);
    if (i <= num - 1)
    {
        Console.Write(", ");
    }
}
}
else
{
    Console.Write($"Кубы чисел от 1 до {num}: ");
for (int i = 1; i >= num; i--)
{
    int cube = i * i * i;
    Console.Write(cube);
    if (i >= num + 1)
    {
        Console.Write(", ");
    }
}
}
Console.ReadLine();