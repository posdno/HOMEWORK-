int [,] matrix1 = CreateArray(2, 2);
matrix1 = FillArray(matrix1);
Console.WriteLine("Первая матрица:");
PrintArray(matrix1);

int[,] matrix2 = CreateArray(2, 2);
matrix2 = FillArray(matrix2);
Console.WriteLine("Вторая матрица:");
PrintArray(matrix2);

int[,] array = MultiplicationMatrix(matrix1, matrix2);
Console.WriteLine("Итоговая матрица:");
PrintArray(array);

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
            array[i, j] = rand.Next(1, 5);
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

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) Console.WriteLine("Матрицы нельзя перемножить");

    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(0)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix[i, j] = 0;
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    matrix[i, j] += matrix[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return matrix;
}