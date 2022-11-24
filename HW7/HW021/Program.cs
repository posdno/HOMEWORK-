int[,] matrix = CreateArray(3, 3);
matrix = FillArray(matrix);
Console.WriteLine("Исходный массив:");
PrintArray(matrix);
ColumnAverage(matrix);

int[,] CreateArray(int n, int m)
{
    int[,] array = new int[n, m];
    return array;
}

int[,] FillArray(int[,] array)
{

    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(5, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
    }
}

void ColumnAverage (int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        double average = sum / (array.GetLength(1));
        Console.WriteLine(average);
    }
}