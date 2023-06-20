using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Logger
{
    public class LoggerContract : ILogContract
    {
        void ILogContract.LogData(string logType, string data)
        {
            ILogger logger = null;
            if (logType.Trim() == "xml")
            {
                logger = new XmlLogger();
                logger.CreateLogFile("log.xml");
                logger.WriteLogFile(data);
            }
            if (logType.Trim() == "text")
            {
                logger = new TextLogger();
                logger.CreateLogFile("log.txt");
                logger.WriteLogFile(data);
            }
        }
    }
}
