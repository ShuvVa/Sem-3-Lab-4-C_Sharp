using System;

namespace Program 
{
    class Logger : IDisposable
    {
        
        static public bool Enable;
        
        public Logger(string str)
        {
            this.nameClass = str;
            if (Enable) Console.Write($"\nConstruct {this.nameClass}\n");
        }

        public void OutFuctName(string name)
        {
            if (Enable) Console.Write($"Function {name} begin to work.");
        }

        public void Dispose()
        {
            if (Enable) Console.Write($"\nDestruct {nameClass}\n");
        }

        string nameClass;
    }

    
}
