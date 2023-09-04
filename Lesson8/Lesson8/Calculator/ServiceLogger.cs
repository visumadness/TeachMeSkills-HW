using E1.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1.Calculator
{
    internal class ServiceLogger
    {
        private readonly ILogger _logger;

        public ServiceLogger(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(Logger));
        }
        public void LogAll(string inputMessage, string outputMessage)
        {
            if (inputMessage == "")
            {
                inputMessage = "null";
            }
            _logger.Log($"Entered value: \"{inputMessage}\"\nOperation result\"{outputMessage}\"");
        }

        public void LogOneMore(ConsoleKey inputMessage)
        {
            _logger.Log($"Selected key: {inputMessage}\n");
        }
    }
}
