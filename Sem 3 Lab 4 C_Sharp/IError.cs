using System.IO;

namespace Program
{
    public abstract class IError : System.Exception
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

        ~IError()
        {
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

 public class MathIError : IError
    {
        private string m_mathIError;
        public MathIError(string error, double a, double b, char op) : base(error)
        {
            m_mathIError = a + " " + op + " " + b;
        }

        public new string what()
        {
            string error = m_IError + " : " + m_mathIError;
            return error;
        }
    }

    public class InputIError : IError
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
