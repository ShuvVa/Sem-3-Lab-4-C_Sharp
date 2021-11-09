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
            nameClass = str;
            if (Enable) Console.WriteLine($"\nConstruct {str}\n");
        }

        public void OutFuctName(string name, bool _enable)
        {
            if (_enable) Console.WriteLine($"Function {name} begin to work.");
        }

        ~Logger(){
            if (Enable) Console.WriteLine($"\nDestruct {nameClass}\n");
        }

        string nameClass;
    }

    
}
