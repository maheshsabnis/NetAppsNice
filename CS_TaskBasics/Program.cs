// See https://aka.ms/new-console-template for more information
using CS_TaskBasics;
using System.Diagnostics;

Console.WriteLine("Demo Task Basics");
var syncFileReadTimer = Stopwatch.StartNew();

FilesReader reader = new FilesReader();
// The Task<T> is a class that represent an executing thrad
// that performs an async operation and return the result of the type T 
Task<string> t1 = Task.Factory.StartNew<string>(() =>
{
    string str = reader.ReadHuntFile();
    return str;
});

Task<string> t2 = Task.Factory.StartNew<string>(() =>
{
    string str = reader.ReadBondFile();
    return str;
});

// Collect results from both tasks

string huntData = t1.Result;
string bondData = t2.Result;

var syncFileReadDuration = syncFileReadTimer.Elapsed.TotalMilliseconds;

Console.WriteLine($"{huntData} \n and \n " +
    $" {bondData} \n Time To read File Synchronously = {syncFileReadDuration}");

Console.WriteLine("Reading Files Asynchronously");

var asyncFileReadTimer = Stopwatch.StartNew();

FilesReaderAsync asyncReader = new FilesReaderAsync();

var asyncHunbtData = await asyncReader.ReadHuntFileAsync();
var asyncBindData = await asyncReader.ReadBondFileAsync();

var asyncFileReadDuration = asyncFileReadTimer.Elapsed.TotalMilliseconds;


Console.WriteLine($"{asyncHunbtData} \n and \n " +
    $" {asyncBindData} \n Time To read File Synchronously = {asyncFileReadDuration}");


Console.ReadLine();
