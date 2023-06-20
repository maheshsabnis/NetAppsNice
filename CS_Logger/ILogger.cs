using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Logger
{
    internal interface ILogger
    {
        void CreateLogFile(string fileName);
        void WriteLogFile(string data);
    }
}
