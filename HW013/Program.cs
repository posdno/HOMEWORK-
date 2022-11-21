int [] GetNumbers (int count)
{
    int []array=new int [count];
    int i=0;
    while(i<count)
    {
        array[i]=new Random().Next(0, 100);
        i++;
    }
    return array;
}

string ArrayTostring(int[]array)
{
    string result=String.Empty;
    int i=0;
    while(i<array.Length)
    {
        result=result+array[i]+" ";
        i++;
    }
    return result;
}

Console.WriteLine(ArrayTostring(GetNumbers(5)));
Console.WriteLine(ArrayTostring(GetNumbers(3)));

