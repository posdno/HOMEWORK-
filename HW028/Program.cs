int m = Input("Введите M:");
int n = Input("Введите N:");
Console.WriteLine($"Cумма элементов от {m} до {n} = {SumNatNambers(m, n)}");

int Input(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int SumNatNambers(int m, int n)
{
    if (m == n) return n;
    return n+ SumNatNambers(m, n - 1);
}
