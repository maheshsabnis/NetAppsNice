using CS_MyGenerics;
using CS_MyGenerics.Schema;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("DEMO Custom Generics");

//GenericStack<int> stkInt = new GenericStack<int>();

//stkInt.Push(1);
//stkInt.Push(2);
//stkInt.Push(3);
//stkInt.Push(4);
//stkInt.Push(5);

//foreach (int i in stkInt.ShowItems())
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine();

//Console.WriteLine($"Poped data {stkInt.Pop()}");
//Console.WriteLine(  );
//Console.WriteLine("Data after POP");
//foreach (int i in stkInt.ShowItems())
//{
//    Console.WriteLine(i);
//}

GenericStack<Employee> stack1 = new GenericStack<Employee>();

foreach (Employee emp in stack1.ShowItems())
{
    if (emp.DeptName == "IT") { }
}

GenericStack<Director> stack2 = new GenericStack<Director>();
GenericStack<Manager> stack3 = new GenericStack<Manager>();

 

Console.ReadLine();


public class Employee
{
    public int EmpNo { get; set; }
    public string? EmpName { get; set; }
    public string? DeptName { get; set; }
}


public class Director : Employee
{ 

}

public class Manager : Employee
{

}