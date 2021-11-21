using System;

namespace Program 
{

    //public class Enable_Logger
    //{
        

    //    public Enable_Logger(bool get)
    //    {
    //        Enable = get;
    //    }
    //}
    class Logger : IDisposable
    {
        //public bool enable;

        static public bool Enable;
        //public Logger(bool _enable = false)
        //{
        //    enable = _enable;
        //}
        
        //public Logger(string str)
        //{
        //    this.nameClass = str;
        //}
        public Logger(string str/*, bool _enable = false*/)//: this(str)
        {
            //this.enable = _enable;
            this.nameClass = str;
            if (Enable) Console.WriteLine($"\nConstruct {this.nameClass}\n");
        }

        public void OutFuctName(string name/*, bool _enable*/)
        {
            if (Enable) Console.WriteLine($"Function {name} begin to work.");
        }

        public void Dispose()
        {
            //Console.Beep();
            if (Enable) Console.WriteLine($"\nDestruct {nameClass}\n");
        }
        ~Logger(){
            if (Enable) Console.WriteLine($"\nDestruct {nameClass}\n");
        }

        string nameClass;
    }

    
}
