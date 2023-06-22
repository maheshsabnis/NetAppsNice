// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Thread t1 = new Thread(PrintNumbersAscending);

Thread t2 = new Thread(PrintNumbersDescending);
t1.Priority = ThreadPriority.BelowNormal;
t1.Start();

t2.Start();

Console.ReadLine();


static void PrintNumbersAscending()
{
	for (int i = 0; i < 10; i++)
	{
        Console.WriteLine($"Increment = {i}");
    }
}

static void PrintNumbersDescending()
{
    for (int i = 10; i > 0; i--)
    {
        Console.WriteLine($"Increment = {i}");
    }
}