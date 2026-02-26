using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Logger
    {
        public Action<string> LogHandler;

        internal void Log(string message)
        {
            if (LogHandler != null)
            {
                LogHandler(message);
            }
        }
            
    }
}
