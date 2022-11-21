double Pow(int a, int n)
{
    if(a==0 && n==0) return double.NaN;
    bool flag = n>0;
    if (n<0) n=-n;
    int res = 1;
    for (int i=0; i<n; i++) res*=a;
    if (flag) return res;
    else return 1.0/res;
}
Console.WriteLine(Pow(5, -2));
Console.WriteLine(Pow(5, 0));
Console.WriteLine(Pow(0, 0));
Console.WriteLine(Pow(3, 5));
Console.WriteLine(Pow(2, 4));
