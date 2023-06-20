// See https://aka.ms/new-console-template for more information
using CS_Interfaces.Models;

Console.WriteLine("DEMO Interfaces");
// Using Class Instance
ImplicitMath m1 =new ImplicitMath();
Console.WriteLine($"Add = {m1.Add(10,20)}");
Console.WriteLine($"Multiply = {m1.Multiply(19,29)}");

// Using interface reference (aka Contract)
IMath m2 = new ImplicitMath();
Console.WriteLine($"Add = {m2.Add(10, 20)}");
Console.WriteLine($"Multiply = {m2.Multiply(19, 29)}");


IMath m3 = new ExplicitMath ();

Console.WriteLine($"Add = {m3.Add(10, 20)}");
Console.WriteLine($"Multiply = {m3.Multiply(19, 29)}");


INewMath m4 = new ExplicitMath();

Console.WriteLine($"Add Square = {m4.Add(4,5)}");
Console.WriteLine($"Multiple Square = {m4.Multiply(3,4)}");


Console.ReadLine();
