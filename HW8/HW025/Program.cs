Console.WriteLine($"Введите размер массива n*m*1:");
int n = InputSize("Введите n: ");
int m = InputSize("Введите m: ");
int l = InputSize("Введите l: ");
int[,,] matrix = new int[n, m, l];
CreateArray(matrix);
PrintArray(matrix);

int InputSize(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,,] array)
{
    int[] arr = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for (int i = 0; i < arr.GetLength(0); i ++)
    {
        arr[i] = new Random().Next(10, 99);
        number = arr[i];
        if (i >=1)
        {
            for (int j = 0; j < i; j++)
            {
                while (arr[i] == arr[j])
                {
                    arr[i] = new Random().Next(10, 99);
                    j = 0;
                    number = arr[i];
                }
                number = arr[i];
            }
        }
    }
    int index = 0;
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                array[n, m, l] = arr[index];
                index++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}; ");
            }
            Console.WriteLine();
        }
    }
}
