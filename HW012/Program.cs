int GetNumberSum(int value)
{
    int sum = 0;
    if (value < 0) value = -value;
    if(value ==0 || value < 10) return sum = value;

    while (value >= 10)
    {
        sum = sum + value % 10;
        value = value/10;
    }
    sum = sum + value;
    return sum;

}

Console.WriteLine(GetNumberSum(452));
Console.WriteLine(GetNumberSum(82));
Console.WriteLine(GetNumberSum(9012));