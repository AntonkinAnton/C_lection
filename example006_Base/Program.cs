int a = new Random().Next(0, 101);
int b = new Random().Next(0, 101);
int c = new Random().Next(0, 101);
int d = new Random().Next(0, 101);
int e = new Random().Next(0, 101);
int max = a;
string let = "a";
if (b > max)
{
    max = b;
    let = "b";
}
if (c > max)
{
    max = c;
    let = "c";
}
if (d > max)
{
    max = d;
    let = "d";
}
if (e > max)
{
    max = e;
    let = "e";
}
Console.WriteLine("a=" + a);
Console.WriteLine("b=" + b);
Console.WriteLine("c=" + c);
Console.WriteLine("d=" + d);
Console.WriteLine("e=" + e);
Console.Write("Max is " + max + " (" + let + ")");

