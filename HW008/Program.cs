Console.Write("Введите пятизначное число  ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 100000 || n < 10000) Console.Write("Повторите ввод");
else
{
    if (n / 10000 == n % 10 || n / 1000 % 10 == n / 100 % 10) Console.Write("Введенное число - палиндром");
    else Console.Write("Введенное число не является палиндромом");
}
