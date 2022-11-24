double[,] CreateArray(int n, int m)
{
    double[,] array = new double [n, m];
    return array;
}

double[,] FillArray (double[,] array, int m, int n)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * 100;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
    }      
}

double[,] array = CreateArray(3, 4);
array = FillArray(array, -10, 10);
PrintArray(array);