// See https://aka.ms/new-console-template for more information
using CS_SImpleFiles.Operations;

Console.WriteLine("Simple File Operations");

FileOperations file = new FileOperations();
string fileName = @"C:\Nice\MyFile.txt";
file.CreateFile(fileName);

file.WritFile(fileName, "The File is created using Sync Code");

Console.WriteLine($"Reading after first Statement {file.ReadFile(fileName)}");


    file.WritFile(fileName, new string[] {"Statem1 ", "Sattement 2", "Statememtn 3" });

Console.WriteLine($"Reading after array Statement {file.ReadFile(fileName)}");

file.AppendFile(fileName, "Statement 4 Appended");

Console.WriteLine($"Reading after Append {file.ReadFile(fileName)}");

Console.ReadLine();
