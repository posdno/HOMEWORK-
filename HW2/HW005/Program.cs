Console.Write ("Введите трехзначное число:   ");
int n = Convert.ToInt32(Console.ReadLine());

if (n<0) n = -n;
    if(n<100 || n>1000) Console.Write("Вы ввели нетрехзначное число, повторите ввод");
    else 
    {
      Console.Write("Вторая цифра этого числа: ");
      Console.WriteLine(n/10%10);
    }
