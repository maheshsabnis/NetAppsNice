using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Logger
{
    public interface ILogContract
    {
        void LogData(string logType, string Data);
    }
}
