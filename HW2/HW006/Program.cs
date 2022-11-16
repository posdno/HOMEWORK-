Console.Write("Введите число  ");
int n=Convert.ToInt32(Console.ReadLine());
if (n < 0) n = -n;
while (n>1000) n = n/100;
if (n<100) Console.Write("Третьей цифры нет ");
    else
    {
        Console.Write("Третья цифра введенного числа -   ");
        Console.WriteLine(n%10);
    }
