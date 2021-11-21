using System;

namespace Program 
{
    class Logger : IDisposable
    {
        
        static public bool Enable;
        
        public Logger(string str)
        {
            this.nameClass = str;
            if (Enable) Console.WriteLine($"\nConstruct {this.nameClass}\n");
        }

        public void OutFuctName(string name)
        {
            if (Enable) Console.WriteLine($"Function {name} begin to work.");
        }

        public void Dispose()
        {
            if (Enable) Console.WriteLine($"\nDestruct {nameClass}\n");
        }
        //~Logger(){
        //    if (Enable) Console.WriteLine($"\nDestruct {nameClass}\n");
        //}

        string nameClass;
    }

    
}
