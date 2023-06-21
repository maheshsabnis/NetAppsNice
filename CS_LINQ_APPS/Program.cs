using CS_LINQ_APPS.Models;
using CS_LINQ_APPS.Database;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("DEMO LINQ With Data");

EmployeesDb employees = new EmployeesDb();

// 1. All Employees for Specific Department

var Res_1 = from emp in employees
            where emp.DeptName ==  "D1"
            select emp;

Console.WriteLine("All Employees for D1 DeptName");
PrintResult(Res_1);
Console.WriteLine();
Console.WriteLine("Employees Salary More ythan Rs 40000");

var Res_2 = from emp in employees
            where emp.Salary > 40000
            select emp;
PrintResult(Res_2);
Console.WriteLine();

Console.WriteLine("Employees in descending order of Name");
var Res_3 = from emp in employees
            where emp.Salary > 40000
            orderby emp.EmpName descending
            select emp;
PrintResult(Res_3);
Console.WriteLine();

Console.WriteLine("Print Sum of Salary for Each DeptName");

var Res_4 = from emp in employees
            group emp by emp.DeptName into EmpDept /* A group (collection) for each DeptName*/
            select new /* Anonymous Type (Runtime Class and its instance) */
            {
                DeptName = EmpDept.Key, /*Key based on which the grouop is created */
                Salary =  EmpDept.Sum(x => x.Salary) /* Sume of Salary of all records in each group*/
            };

foreach (var item in Res_4)
{
    Console.WriteLine($"Sum of Salary for DeptName : {item.DeptName} is {item.Salary}");
}


Console.ReadLine();


static void PrintResult(IEnumerable<Employee> records)
{
    foreach (var record in records)
    {
        Console.WriteLine($"{record.EmpNo} {record.EmpName} {record.DeptName} {record.Salary}");
    }
}