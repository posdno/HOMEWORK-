void InterselectionPointX(double k1, double k2, double b1, double b2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k2*(b2-b1)/(k1-k2)+b2;
    if (k1==k2) Console.Write ("Заданные прямые не пересекаются");
    else Console.Write($"Точка пересечения прямых:  ({x};{y}");
}

Console.Write("Введите b1  ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k1  ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b2  ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите k2  ");
double k2 = double.Parse(Console.ReadLine());
InterselectionPointX(k1, k2, b1, b2);
