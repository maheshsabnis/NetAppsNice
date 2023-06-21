
using CS_ExtensionMethod.Models;

Console.WriteLine("DEMO Extension Method");
ClsMath m  =new ClsMath ();

Console.WriteLine($"Add = {m.Add(2,3)}");

Console.WriteLine($"Add = {m.Add(10,20)}"); // Runtime will call the local Add() method for MyClass 
 

Console.WriteLine($"Multiply with Extenion = {m.Mult(10,20)}");

string myString = "Microset .NET 6 is great platform for Modern Apps that includs Desktop, Mobile, Web, and Cloud based application.";

Console.WriteLine($"Word Count in string {myString} is  = {myString.GetWordCount()}");

Console.ReadLine(); 





