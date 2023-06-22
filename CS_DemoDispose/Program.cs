// See https://aka.ms/new-console-template for more information
Console.WriteLine("DEMO Dispose");

MyClass m = new MyClass ();

m.Display();

m.Dispose ();   

Console.ReadLine();



internal class MyClass : IDisposable
{
    public MyClass()
    {
        Console.WriteLine("Object Created");
    }

    public void Display()
    {
        Console.WriteLine("Display Calledd");
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Destructor
    /// </summary>
    ~MyClass()
    {
        for (int i = 0; i < 10; i++) 
        {
            Console.WriteLine("HAHAHAHAHIHIHIHOIHHOOHOOHOO");
        }
        Console.WriteLine("Object Destroyed");
        Console.ReadLine();
    }


}

