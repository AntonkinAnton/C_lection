int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = new Random().Next(0, 10000);
int b1 = new Random().Next(0, 10000);
int c1 = new Random().Next(0, 10000);
int a2 = new Random().Next(0, 10000);
int b2 = new Random().Next(0, 10000);
int c2 = new Random().Next(0, 10000);
int a3 = new Random().Next(0, 10000);
int b3 = new Random().Next(0, 10000);
int c3 = new Random().Next(0, 10000);

// int max1 = Max(a1,b1,c1);
// int max2 = Max(a2,b2,c2);
// int max3 = Max(a3,b3,c3);

int fin = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(a1 + ", " + b1 + ", " + c1 + ", " + a2 + ", " + b2 + ", " + c2 + ", " + a3 + ", " + b3 + ", " + c3);
Console.WriteLine(fin);