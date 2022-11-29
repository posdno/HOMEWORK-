Console.Write("Введите натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());

int m = 1;
Console.WriteLine(NatNumbers(n, m));

int NatNumbers(int n, int m)
{
    if (n == m) return n;
    else 
       Console.Write($"{NatNumbers(n, m + 1)}, ");
    return m;
}
