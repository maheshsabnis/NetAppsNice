namespace CS_Logger
{
    internal class TextLogger : ILogger
    {
        void ILogger.CreateLogFile(string fileName)
        {
            Console.WriteLine($"Log File Created {fileName}");
        }

        void ILogger.WriteLogFile(string data)
        {
            Console.WriteLine($"Log Data Written {data}");
        }
    }
}