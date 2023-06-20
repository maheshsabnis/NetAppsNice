using CS_Logger;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Logger Utilizer");
ILogContract logContract = new LoggerContract();

logContract.LogData("xml", "This Data will be Written in the XML File");

logContract.LogData("text", "This Data will be written in the Text File");


Console.ReadLine();
