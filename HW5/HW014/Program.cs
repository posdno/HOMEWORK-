void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}
int [] CreateAndFill(int count)
{
    int[] array = new int [count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(100, 900);
    }
    return array;
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}
int Count (int[] array)
{
    int rez = 0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0) rez++;
    }
    return rez;
}

Console.Clear();
int len = 10;
int[] arr = CreateAndFill(len);
FillArray(arr);
PrintArray(arr);
int rezalt = Count(arr);
Console.WriteLine("Количество четных элементов в массиве - ");
Console.WriteLine(rezalt);