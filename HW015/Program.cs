void FillArray (int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

int[] CreateAndFill(int count)
{
    int[] array = new int[count];
    for (int i = 0; i<count; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void PrintArray (int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}
int Sum (int[] array)
{
    int result = 0;
    for(int i=0; i<array.Length; i++)
    {
        if (i%2==0)
        result=result+array[i];
    }
    return result;
}
Console.Clear();
int len = 10;
int[] arr = CreateAndFill(len);
FillArray(arr);
PrintArray(arr);
int result = Sum (arr);
Console.WriteLine("Сумма элементов на нечетных позициях - ");
Console.WriteLine(result);