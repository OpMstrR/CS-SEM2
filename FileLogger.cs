using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ModulkTask2
{
    class FileLogger
    {
        private string _logFilePath = "logPD21.txt";

        public void LogMessage(string message)
        {
            string logEntry = $"[{DateTime.Now}] {message}";
            File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
            Console.WriteLine($"[FileLogger] Повідомлення записано у файл: {logEntry}");
        }
    }
}
