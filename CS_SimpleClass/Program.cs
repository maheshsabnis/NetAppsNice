// See https://aka.ms/new-console-template for more information



using CS_SimpleClass.AppClasses;

Console.WriteLine("Demo Simple Operation class");

// 1. CReat an instance of the class

SimpleOperations obj = new SimpleOperations();

double x, y;

/* Lets accept data for x and y */

Console.WriteLine("Enter x");
// L.H.S = R.H.S.
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter y");
// L.H.S = R.H.S.
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"{x} raised to {y} is = {obj.Popwer(x,y)}");

int a =  6, b =  -2;

Console.WriteLine($"{a} / {b} is = {obj.Division(a,b)}");

//string Name = "Tejas Mahesh Sabnis";
string Name = string.Empty;
Console.WriteLine($"Reverse of {Name} is = {obj.Reverse(Name)}");



Console.ReadLine();
