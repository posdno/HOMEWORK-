int GetCountElement()
{
    Console.WriteLine("Введите количество элементов массива ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[] CreateAndFillArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }
    return array;
}

void Print(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

double DifferenceMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double rez = max - min;
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
        rez = max - min;
    }
    Console.Write("Max элемент:  ");
    Console.WriteLine(max);
    Console.Write("Min элемент:  ");
    Console.WriteLine(min);
    return rez;
}

int num = GetCountElement();
double[] array = CreateAndFillArray(num);
Print(array);
double diff = DifferenceMaxMin(array);
Console.Write("Разница между max и min:  ");
Console.WriteLine(diff);
