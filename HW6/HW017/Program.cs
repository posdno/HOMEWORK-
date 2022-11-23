double[] ReadFromConsoleArray(int size)
{
    double[] collection = new double[size];
    for (int i = 0; i<size; i++)
    {
        Console.Write("Введите числа ");
        collection[i] = double.Parse(Console.ReadLine());
    }
    return collection;
}

int CheckNumber(double[]array)
{
    int result = 0;
    int size = array.Length;
    for (int i = 0; i<size; i++)
    {
        if (array[i] < 0) result = result + 1;
    }
    return result;
}

string Print(int count, double[] numbers)
{
    string res = "Количество положительных чисел - " + count + "шт. в массиве" + "[" + string.Join(' ', numbers) + "]";
    return res;
}

int GetCountElement()
{
    Console.Write("Сколько значений будете вводить?   ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num = GetCountElement();
double[] array = ReadFromConsoleArray(num);
int count = CheckNumber(array);
Console.WriteLine(Print(count, array));
