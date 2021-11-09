using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IError
{
    abstract class IError
    {
        protected string m_IError;
        
        public IError(string error)
        {
            m_IError = error;
        }

        public string what()
        {
            return m_IError;
        }

        ~IError(){
            string path = @"C:\ErrorLog\Error.txt";
            string txt = ($"{m_IError}\n");
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(txt);
            }
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(txt);
            }

            
        }
    }

    class MathIError : IError
    {
        private string m_mathIError;
        public MathIError(string error, int a, int b, char op) : base (error)
        {
            m_mathIError = a + " " + op + " " + b;
        }

        public new string what()
        {
            string error = m_IError + " : " + m_mathIError;
            return error;
        }
    }

    class InputIError : IError
    {
        private string m_inputIError;
        public InputIError(string error, string inputtext) : base(error)
        {
            m_inputIError = inputtext;
        }

        public new string what()
        {
            string error = m_IError + " : " + m_inputIError;
            return error;
        }
    }
}
