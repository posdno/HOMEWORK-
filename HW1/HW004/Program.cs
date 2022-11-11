int N = new Random().Next(1,  10);
Console.Write("Выбранный интервал от 1 до ");
Console.WriteLine(N);
Console.Write("Четные числа: ");
int a = 1;
while (a<=N);
{
    if(a % 2 == 0);
    {
        Console.WriteLine(a);
    }
    a=a+1;
}
