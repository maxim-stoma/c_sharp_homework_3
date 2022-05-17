void PointCoordinate(int[] coord)
{
    int length = coord.Length;
    int index = 0;
    
    for (index = 0; index < length; index++)
    {
        if (index == 0)
        {
            Console.Write($"Введите координату по оси X: ");
        }
        else if (index == 1)
        {
            Console.Write($"Введите координату по оси Y: ");
        }
        else
        {
            Console.Write($"Введите координату по оси Z: ");
        }
        coord[index] = Convert.ToInt32(Console.ReadLine());
    }
}

void ShowCoordinate(int[] coordinate)
{
    int count = coordinate.Length;
    int pos = 0;
    for (pos = 0; pos < count; pos++)
    {
        Console.Write(coordinate[pos]);
        if (pos <= count - 2)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

int[] pointA = new int[3];
int[] pointB = new int[3];

Console.WriteLine("Первая точка");
PointCoordinate(pointA);
Console.WriteLine("Вторая точка");
PointCoordinate(pointB);
Console.Write("Координаты первой точки: ");
ShowCoordinate(pointA);
Console.Write("Координаты второй точки: ");
ShowCoordinate(pointB);

double distance = Math.Sqrt(((pointA[0] - pointB[0]) * (pointA[0] - pointB[0])) + ((pointA[1] - pointB[1]) * (pointA[1] - pointB[1])) + ((pointA[2] - pointB[2]) * (pointA[2] - pointB[2])));

Console.WriteLine($"Расстояние между точками равно {Math.Round(distance, 2)}");
Console.ReadLine();