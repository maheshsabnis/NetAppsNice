
// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("DEMO Collections");

ArrayList arrayList = new ArrayList();
// int, System.Int32
arrayList.Add(10);
arrayList.Add(20);
arrayList.Add(30);
arrayList.Add(40);
// double, System.Double
arrayList.Add(10.5);
arrayList.Add(30.2);
// char, System.Char
arrayList.Add('A');
arrayList.Add('B');
// string, System.String
arrayList.Add("James Bond");
arrayList.Add("Ethan Hunt");
arrayList.Add("Jack Reacher");
// Employee
arrayList.Add(new Employee() { EmpNo = 1, EmpName = "A" });
arrayList.Add(new Employee() { EmpNo = 2, EmpName = "B" });

Console.WriteLine($"Count in ArrayList = {arrayList.Count} ");

foreach (object obj in arrayList)
{
    Console.WriteLine($"Type of obj = {obj.GetType()} abd Value of obj = {obj}");
}
Console.WriteLine(  );

Console.WriteLine("Read integeres");

foreach (object obj in arrayList)
{
    if (obj.GetType() == typeof(int))
    {
        Console.WriteLine(obj);
    }
}

Console.ReadLine();


public class Employee
{
    public int EmpNo { get; set; }
    public string? EmpName { get; set; }
}