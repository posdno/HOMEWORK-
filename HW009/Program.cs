int[] GetHumbers(int count)
{
    int[] array = new int[count];
    
    for (int i = 0; i < count; i++)
    {
        array[i] = (i + 1)*(i + 1)*(i + 1);
    }
    return array;

}

string ArrayToString(int[] array)
{
    string result = string.Empty;
    {
        for (int i = 0; i < array.Length; i++)
             result = result + array[i] + " ";
    }
    return result;
}

Console.WriteLine(ArrayToString(GetHumbers(3)));
Console.WriteLine(ArrayToString(GetHumbers(5)));
Console.WriteLine(ArrayToString(GetHumbers(8)));