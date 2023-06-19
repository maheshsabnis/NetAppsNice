// See https://aka.ms/new-console-template for more information
using CS_Members.Models;

Console.WriteLine("DEMO Class Members");

EmployeeDTO emp1 = new EmployeeDTO();
emp1.EmpNo = 101; // Call set block of the Property
emp1.EmpName = "Ajay"; // Call set block of the Property

// This calls get block of the proeprty
//Console.WriteLine($"EmpNo = { emp.EmpNo} and EmpName = {emp.EmpName}");

EmployeeLogic logic = new EmployeeLogic();
logic.AddEmployee(emp1);
EmployeeDTO emp2 = new EmployeeDTO();
emp2.EmpNo = 102;
emp2.EmpName = "Manish";
logic.AddEmployee(emp2);
EmployeeDTO emp3 = new EmployeeDTO();
emp3.EmpNo = 103;
emp3.EmpName = "Akash";
logic.AddEmployee(emp3);
EmployeeDTO emp4 = new EmployeeDTO();
emp4.EmpNo = 104;
emp4.EmpName = "Ashish";
logic.AddEmployee(emp4);
EmployeeDTO emp5 = new EmployeeDTO();
emp5.EmpNo = 105;
emp5.EmpName = "Mohan";
logic.AddEmployee(emp5);

Console.WriteLine($"No of Records for Employees is = {logic.GetEmployees().Length}");

foreach (EmployeeDTO ep in logic.GetEmployees())
{
    Console.WriteLine($"EmpNo = {ep.EmpNo} and EmpName = {ep.EmpName}");
}




Console.ReadLine();
