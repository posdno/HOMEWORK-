Console.Write("Введите цифру, обозначающую день недели  ");
int d = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(d);

int[] weeek = {1, 2, 3, 4, 5, 6, 7};
int n = weeek.Length;
int index = 0;
//if (d<1||d>7) Console.WriteLine("повторите ввод");

while(index<n)
{
    if (d==weeek[5] || d==weeek[6]) Console.WriteLine(" это выходной");
    else Console.WriteLine("не выходной день");
    break;
}
index++;