void PointCoordinate(int[] coord)
{
    int length = coord.Length;
    int index = 0;
    
    while (index < length)
    {
        Console.Write($"Введите координату по оси {index}: ");
        coord[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}

void ShowCoordinate(int[] coordinate)
{
    int count = coordinate.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(coordinate[pos]);
        if (pos <= count - 2)
        {
            Console.Write(", ");
        }
        pos++;
    }
    Console.WriteLine();
}

int[] pointA = new int[3];
int[] pointB = new int[3];

PointCoordinate(pointA);
ShowCoordinate(pointA);
PointCoordinate(pointB);
ShowCoordinate(pointB);