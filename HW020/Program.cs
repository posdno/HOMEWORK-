Console.Write("Введите строку:");
int x = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец:"); 
int y = Convert.ToInt32(Console.ReadLine()) - 1;
int[,] matrix = CreateArray(5, 7);
matrix = FillArray(matrix);
Console.WriteLine("Исходный массив:");
PrintArray(matrix);
ElementSearch(matrix, x, y);

int[,] CreateArray(int n, int m)
{
    int[,] array = new int[n, m];
    return array;
}

int[,] FillArray(int[,] array)
{
    Random rand  = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 100);
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

void ElementSearch (int[,] array, int x, int y)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ( x < 0 | x > array.GetLength(0) - 1 | y < 0 | y > array.GetLength(1) - 1)
            {
                Console.WriteLine("Элемент не существует");
            }
            else Console.WriteLine("Значение элемента массива = {0}", array[x, y]);
            Console.ReadLine();
        }
    }
}
