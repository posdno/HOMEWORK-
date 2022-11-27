Console.Write("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateArray(n, m);
matrix = FillArray(matrix);
Console.WriteLine("Исходный массив:");
PrintArray(matrix);
Console.WriteLine();
MinSumStringMatrix(matrix);

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
            array[i, j] = rand.Next(5, 50);
        } 
    }
    return array;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
    }
}

void MinSumStringMatrix(int[,] matrix)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum+=matrix[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i==0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = 1;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов - {index+1}");
}
