using E1.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1.Logger
{
    public class FileAndConsoleLogger : ILogger
    {
        private readonly ILogger[] _loggers;

        public FileAndConsoleLogger(params ILogger[] loggers)
        {
            _loggers = loggers;
        }

        public void Log(string message)
        {

            foreach(var logger in _loggers)
            {
                logger.Log(message);
            }
        }
    }
}
