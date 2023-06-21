// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Demo Generics");

List<int> intList = new List<int>();

intList.Add(10);
intList.Add(20);
intList.Add(30);

foreach (int i in intList)
{
    Console.WriteLine(  i );
}

List<string> strList = new List<string>();
strList.Add("Tejas");
strList.Add("Mahesh");
strList.Add("Ramesh");

foreach (string str in strList)
{
    Console.WriteLine( str );
}

List<Employee> employees = new List<Employee>();
employees.Add(new Employee() { EmpNo=1,EmpName="A"});
employees.Add(new Employee() { EmpNo = 2, EmpName = "B" });

foreach (Employee employee in employees)
{
    Console.WriteLine($"EmpNo {employee.EmpNo} and EmpName {employee.EmpName}");
}


// Key:Value Pair
Dictionary<string, Employee> empDictionary = new Dictionary<string, Employee>();

empDictionary.Add("Emp-101", new Employee() { EmpNo = 101, EmpName = "Emp1" });
empDictionary.Add("Emp-102", new Employee() { EmpNo = 102, EmpName = "Emp2" });
empDictionary.Add("Emp-103", new Employee() { EmpNo = 103, EmpName = "Emp3" });
empDictionary.Add("Emp-104", new Employee() { EmpNo = 104, EmpName = "Emp4" });

//empDictionary.Add("Emp-103", new Employee() { EmpNo = 104, EmpName = "Emp4" }); // Eror

Console.WriteLine($"Records in Dictionary = {empDictionary.Count}");

var record = empDictionary.TryGetValue("Emp-103", out Employee? emp);
if (record)
{
    Console.WriteLine($"EmpNo {emp.EmpNo} and EmpName {emp.EmpName}");
}
else
{
    Console.WriteLine("No record Found");
}


Dictionary<string, List<Employee>> empDb = new Dictionary<string, List<Employee>>();

empDb.Add("IT",new List<Employee>() { new Employee() {EmpNo=1,EmpName="A" }, new Employee() {EmpNo=2, EmpName="B" } });
empDb.Add("HR", new List<Employee>() { new Employee() { EmpNo = 3, EmpName = "C" }, new Employee() { EmpNo = 4, EmpName = "D" } });








Console.ReadLine();

public class Employee
{
    public int EmpNo { get; set; }
    public string? EmpName { get; set; }
}