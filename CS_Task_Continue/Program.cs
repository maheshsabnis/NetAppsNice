// See https://aka.ms/new-console-template for more information
using CS_Task_Continue;

Console.WriteLine("Task Continue");

FilesReader reader = new FilesReader();


Task<string> t = Task.Factory.StartNew<string>(() => {
    Console.WriteLine("First Task");
    string first = reader.ReadHuntFile();
    Console.WriteLine("First Task Completed");
    return first;

}).ContinueWith<string>((t2) => {
    // t2 represents the previous task of which data can be read 
    Console.WriteLine("Started Second Task");
    string second = reader.ReadBondFile();
    Console.WriteLine("Second Task Over");
    string third = t2.Result + "\n" + second;
    return third;
});

var result = t.Result;

Console.WriteLine($"Received Final Result {result}");

Console.ReadLine();
