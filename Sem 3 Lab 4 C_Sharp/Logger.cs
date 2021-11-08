using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class Logger
    {
        public bool Enable;
        
        public Logger(string str, bool enable = false)
        {
            Enable = enable;
            if (Enable) Console.WriteLine($"\nConstruct {str}\n");
        }
            
    }
}
