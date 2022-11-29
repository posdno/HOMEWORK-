Console.WriteLine("Введите два положительных числа: M и N");
int m = Input("Введите M: ");
int n = Input("Введите N: ");
Console.WriteLine($"A({m}), {n}) = {Akkerman (m, n)}");

int Input(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int Akkerman (int m, int n)
{
    if (m == 0) return n+1;
    if (m > 0 && n == 0) return Akkerman (m - 1, 1);
    else return Akkerman (m-1, Akkerman (m, n - 1));
}