// See https://aka.ms/new-console-template for more information
using CS_AppliedOOPs.Logic;
using CS_AppliedOOPs.Models;
using CS_AppliedOOPs.PolymorphicClass;
using System.IO;

Console.WriteLine("Using C# OOPs with Applied Way");
/// Object Initialization
Director director1 = new Director() 
{
  EmpNo = 101,EmpName="D1",Salary=400000,AirFare = 3000,ElectricityBill=1000,OtherAllowances=8000
};

DirectorLogic directorLogic = new DirectorLogic();
// Passing a Director object as a substitution of Employee object because
// Director is-a Employee
// Liskov Substitution Principal (LSP)
directorLogic.AddEmployee(director1);

Director director2 = new Director()
{
    EmpNo = 102,
    EmpName = "D2",
    Salary = 500000,
    AirFare = 5000,
    ElectricityBill = 6000,
    OtherAllowances = 9000
};

directorLogic.AddEmployee(director2);
// Compiler and Runtime has the directors as Employee Array Only
// In-Memory all Data is present (Employee + Director)
var directors = directorLogic.GetEmployee();


Console.WriteLine("For Directors");

Accountant accountant = new Accountant();

// At Runtime Use the Director object to read data from directors array
foreach (Director director in directors)
{
    Console.WriteLine($"{director.EmpNo} {director.EmpName} {director.Salary} {director.AirFare} {director.ElectricityBill} {director.OtherAllowances}");

    Console.WriteLine($"Salary of EmpNo {director.EmpNo} is = {directorLogic.GetSalary(director)}");
    // Use the polymorphic behavior for the GetTax() method for Employee of the type Director
    Console.WriteLine($"Tax of EmpNo {director.EmpNo} is = {accountant.GetTax(director,directorLogic)}");

}
Console.WriteLine();

Console.WriteLine("For Managers");

Manager m1 = new Manager() { EmpNo = 103, EmpName = "M1", Salary = 10000, PetrolAlloances = 3000, PhoneBill = 4000 };
ManagerLogic managerLogic = new ManagerLogic();
managerLogic.AddEmployee(m1);
Manager m2 = new Manager() { EmpNo = 104, EmpName = "M2", Salary = 20000, PetrolAlloances = 2000, PhoneBill = 3000 };
managerLogic.AddEmployee(m2);

var managers = managerLogic.GetEmployee();

foreach (Manager manager in managers)
{
    Console.WriteLine($"{manager.EmpNo} {manager.EmpName} {manager.Salary} {manager.PetrolAlloances} {manager.PhoneBill} ");
    Console.WriteLine($"Salary of EmpNo {manager.EmpNo} is = {managerLogic.GetSalary(manager)}");
    // Use the polymorphic behavior for the GetTax() method for Employee of the type Manager
    Console.WriteLine($"Tax of EmpNo {manager.EmpNo} is = {accountant.GetTax(manager, managerLogic)}");
}

Console.ReadLine();
