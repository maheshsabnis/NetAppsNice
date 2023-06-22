// See https://aka.ms/new-console-template for more information
using CS_Parallel_ProcessCollection.Database;
using System.Diagnostics;

Console.WriteLine("DEMO Parallel For");

//Stop Watch
var sequentialIterationTimer = Stopwatch.StartNew();
var empList = new EmployeesDb();
for (int i = 0; i < empList.Count; i++)
{
    empList[i] = ProcessTax.CalculateTax(empList[i]);
    Console.WriteLine($"Processing Employee in Sequence with EmpNo {empList[i].EmpNo} and EmpName {empList[i].EmpName} with TDS = {empList[i].TDS}");
}
Console.WriteLine($"Total Time for Sequential Processing = {sequentialIterationTimer.Elapsed.TotalSeconds}");
Console.WriteLine();

Console.WriteLine("Lets Process The data Parallely");

var parallelIterationTimer = Stopwatch.StartNew();

Parallel.For(0, empList.Count, (i) =>
{
    empList[i] = ProcessTax.CalculateTax(empList[i]);
    Console.WriteLine($"Processing Employee in Parallel with EmpNo {empList[i].EmpNo} and EmpName {empList[i].EmpName} with TDS = {empList[i].TDS}");
});

Console.WriteLine($"Total Time for Sequential Processing = {parallelIterationTimer.Elapsed.TotalSeconds}");
Console.ReadLine();
