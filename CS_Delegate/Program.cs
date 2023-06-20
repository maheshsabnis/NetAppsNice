// See https://aka.ms/new-console-template for more information
namespace CS_Delegate;
public delegate double OpertationHandler(double a, double b);
class Program
{
    static void Main(string[] agrs)
    {
        Console.WriteLine("DEMO Delegate");
        Calle c = new Calle();

        Console.WriteLine($"Direct Call Power - {c.Power(10, 7)}");
        Console.WriteLine(  );

        Console.WriteLine("Using Delegates");
        // 1. Define Delegate Type Instance and pass address of the method to it
        // Name of the method without the parenthesis itself is and adddress
        OpertationHandler handler1 = new OpertationHandler(c.Power);
        // 2. Pass the parameters to delegate type instance
        // This will invoke method implicitly
        Console.WriteLine($"Call Power Method using delegate {handler1(20,5)}");
        Console.WriteLine(  );

        Console.WriteLine("Passing implementation directly to delegate");
        Console.WriteLine("Anunymous Method C#2.0");
        OpertationHandler handler2 = delegate (double x, double y) { return Math.Pow(x, y); };
        Console.WriteLine($"Invokeing Anonymous Method  = {handler2(4,9)}");
        Console.WriteLine(  );
        Console.WriteLine("Simplify the Anonymous Method using Lambda Expression C# 3.0");
        // Parameters a, and d are implicitly declated by compilaer based on the Signeture of the delegate
        // The Lambda is directly converted into Binary and will be executed with Optimization
        OpertationHandler handler3 = (a,b)=> Math.Pow(a,b);
        Console.WriteLine($"Invokeing Lambda Expression  = {handler3(4, 9)}");
        Console.WriteLine();

        Console.WriteLine("Calling method having delegate a input parameter");

        OpertationHandler handler4 = (s, t) => (s * s) + 2 * s * t + (t * t);

        Console.WriteLine("Explicitly Passing delegate object to method");
        Bridge(handler4, 30, 60);
        Console.WriteLine();
        Console.WriteLine("Directly Passing Lambda Expression to method");
        BridgeNew((g, h) => g + h + 10 + 60 - 7);

        Console.ReadLine();
    }

    static void Bridge(OpertationHandler handler, double p1, double p2)
    {
        Console.WriteLine($"Result = {handler(p1,p2)}");
    }

    static void BridgeNew(OpertationHandler handler)
    {
        Console.WriteLine($"Result = {handler(10, 20)}");
    }

}

 










