using E1.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1.Logger
{
    public class ConsoleLogger : ILogger
    {
        
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
