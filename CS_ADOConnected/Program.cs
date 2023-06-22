using CS_ADOConnected.Models;
using CS_ADOConnected.DataAccess;

using System.Text.Json;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("ADP.NET Connected Architecture");

IDataAccess<Department, int> deptDa = new DepartmentDataAccess();

var departments = await deptDa.GetAsync();

Console.WriteLine($"Department Data = {JsonSerializer.Serialize(departments)}");

Department dept = new Department()
{
     DeptNo=100, DeptName="Dept-100",Location="Pune",Capacity=899
};

dept = await deptDa.CreateAsync(dept);

departments = await deptDa.GetAsync();

Console.WriteLine($"After Insert Department Data = {JsonSerializer.Serialize(departments)}");

Department deptToUpdate = new Department()
{
    DeptNo = 100,
    DeptName = "Dept-100",
    Location = "Pune-Bavdhan",
    Capacity = 1899
};

deptToUpdate = await deptDa.UpdateAsync(deptToUpdate.DeptNo, deptToUpdate);

departments = await deptDa.GetAsync();

Console.WriteLine($"After Update Department Data = {JsonSerializer.Serialize(departments)}");

var res = await deptDa.DeleteAsync(100);

departments = await deptDa.GetAsync();

Console.WriteLine($"After Delete Department Data = {JsonSerializer.Serialize(departments)}");
Console.ReadLine();
