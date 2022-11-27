Console.Write("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateArray(n, m);
matrix = FillArray(matrix);
Console.WriteLine("Исходный масси:");
PrintArray(matrix);
Console.WriteLine("Упорядоченный массив:");
BubbleSort(matrix);
PrintArray(matrix);

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

int[,] BubbleSort(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k=j+1; k < array.GetLength(1); k++)
            {
                if (array[i,j] < array[i,k])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    return array;
}
