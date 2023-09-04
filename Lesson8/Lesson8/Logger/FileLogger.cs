using E1.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1.Logger
{
    internal class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            if(!File.Exists(path))
            {
                File.Create(path);
            }
            _path = path;
        }

        public void Log(string message)
        {
            File.AppendAllText(_path, message);
        }
    }
}
