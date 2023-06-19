// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine($"Add = {Add(10,20)}");
Console.WriteLine($"Sub = {Sub(100, 20)}");
Console.ReadLine();


static int Add(int x,int y)
{
    return x + y;
}

static int Sub(int x, int y)
{
    return x - y;
}

