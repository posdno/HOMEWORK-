double Dictance (double x1=7, double y1=-5, double z1=0, double x2=1, double y2=-1, double z2=-9)
{
    double s1=(x1-x2)*(x1-x2);
    double s2=(y1-y2)*(y1-y2);
    double s3=(z1-z2)*(z1-z2);

    double s=Math.Sqrt(s1+s2+s3);
    return s;
}
Console.WriteLine(Dictance());
