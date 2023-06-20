using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Logger
{
    internal class XmlLogger : ILogger
    {
        void ILogger.CreateLogFile(string fileName)
        {
            Console.WriteLine($"Log File Created {fileName}");
        }

        void ILogger.WriteLogFile(string data)
        {
            Console.WriteLine($"Log data Written {data}");
        }
    }
}
