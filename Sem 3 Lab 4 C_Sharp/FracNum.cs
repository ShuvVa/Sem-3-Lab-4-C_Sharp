using System;

namespace Program
{
    class FracNum : Logger
    {
        private double Numerator;
        private double Denominator;
        private double Nod;
        public int GCD(int x, int y)
        {
            return (y != 0) ? GCD(y, x % y) : x;
        }

        //Logger logger;
        public FracNum(string name = "FracNum"/*, bool Enable = false*/) : base(name/*, Enable*/)
        {
            Numerator = 0;
            Denominator = 1;
            Nod = 0;
        }
        public FracNum(double num, double denum, string str = "FracNum2"/*, bool Enable = false*/) : base(str/*, Enable*/)
        {

            //try
            //{
            //    if (denum == 0)
            //        throw MathIError("division by zero", num, denum, '/');
            //}
            //catch (MathIError)
            //{
            //    //cerr << "ERROR: (" << exception.what() << ")\n";
            //    num = 0;
            //    denum = 1;
            //    //abort();
            //}

            if (denum == 0) { denum = num; num = 0;  }

            Numerator = num;

            Denominator = denum;

            Nod = GCD(Convert.ToInt32(Numerator), Convert.ToInt32(Denominator));
            Numerator /= Nod;
            Denominator /= Nod;
            if (Denominator < 0)
            {
                Numerator *= -1;
                Denominator *= -1;
            }
            
        }
        ~FracNum()
        {
            Numerator = 0;
            Denominator = 0;
            Nod = 0;
        }
        public void GetFracNum()
        {
            Logger a = new Logger ("GetFracNum"/*, Enable*/);
            //double _numerator, _denominator;
            Console.Write("Numerator:\n: ");
            this.Numerator = Convert.ToDouble(Console.ReadLine());
            Console.Write("Denominator:\n: ");
            this.Denominator = Convert.ToDouble(Console.ReadLine());
            //return new FracNum(_numerator, _denominator);
            a.Dispose();
        }
        public string ReturnFracNum()
        {
            Logger a = new Logger ("ReturnFracNum"/*, Enable*/);
            string fracnum = ($"{this.Numerator}/{this.Denominator}");
            a.Dispose();
            return fracnum;
        }
        public static FracNum operator +(in FracNum fn1, in FracNum fn2) 
        {
            Logger a = new Logger("Addition"/*, Enable*/);
            if (fn1.Denominator == fn2.Denominator)
            {
                FracNum fn3 = new FracNum(fn1.Numerator+fn2.Numerator, fn1.Denominator);
                a.Dispose();
                return fn3;
            }
            else
            {
                FracNum fn3 = new FracNum(fn1.Numerator*fn2.Denominator+fn2.Numerator*fn1.Denominator, fn1.Denominator*fn2.Denominator);
                a.Dispose();
                return fn3;
            }
            
        }
        public static FracNum operator -(in FracNum fn1, in FracNum fn2) 
        {
            Logger a = new Logger("Substraction"/*, Enable*/);
            if (fn1.Denominator == fn2.Denominator)
            {
                FracNum fn3 = new FracNum(fn1.Numerator-fn2.Numerator, fn1.Denominator);
                a.Dispose();
                return fn3;
            }
            else
            {
                FracNum fn3 = new FracNum(fn1.Numerator*fn2.Denominator-fn2.Numerator*fn1.Denominator, fn1.Denominator*fn2.Denominator);
                a.Dispose();
                return fn3;
            }

        }
        public static FracNum operator *(in FracNum fn1, in FracNum fn2) 
        {
            Logger a = new Logger("Multiplication"/*, Enable*/);
            FracNum fn3 = new FracNum(fn1.Numerator*fn2.Numerator,fn1.Denominator*fn2.Denominator);
            a.Dispose();
            return fn3;
        }
        public static FracNum operator /(in FracNum fn1, in FracNum fn2) 
        {
            Logger a = new Logger("Division"/*, Enable*/);
            FracNum fn3 = new FracNum(fn1.Numerator*fn2.Denominator,fn1.Denominator*fn2.Numerator);
            a.Dispose();
            return fn3;
        }
        public static FracNum operator ^(in FracNum fn, in int power) 
        {
            Logger a = new Logger("Power"/*, Enable*/);
            if (power == 0)
            {
                FracNum fn3 = new FracNum(1,1);
                a.Dispose();
                return fn3;
            }
            else if (power == -1)
            {
                FracNum fn3 = new FracNum(fn.Denominator,fn.Numerator);
                a.Dispose();
                return fn3;
            }
            else if (power < -1)
            {
                FracNum fn3 = new FracNum(Math.Pow(fn.Denominator,Math.Abs(power)),Math.Pow(fn.Numerator,Math.Abs(power)));
                a.Dispose();
                return fn3;
            }
            else
            {
                FracNum fn3 = new FracNum(Math.Pow(fn.Numerator,power),Math.Pow(fn.Denominator,power));
                a.Dispose();
                return fn3;
            }
        }

        //public static FracNum operator =() { return new FracNum(); }
        public static bool operator >(in FracNum fn1, in FracNum fn2) 
        {
            Logger a = new Logger("More"/*, Enable*/);
            double expr1 = fn1.Numerator * fn2.Denominator - fn2.Numerator * fn1.Denominator;
            double expr2 = fn1.Denominator * fn2.Denominator;
            a.Dispose();
            return (expr1 > 0 && expr2 > 0 || expr1 < 0 && expr2 < 0);
        }
        public static bool operator >=(in FracNum fn1, in FracNum fn2)
        {
            Logger a = new Logger("More or equal"/*, Enable*/);
            double expr1 = fn1.Numerator * fn2.Denominator - fn2.Numerator * fn1.Denominator;
            double expr2 = fn1.Denominator * fn2.Denominator;
            a.Dispose();
            return (expr1 >= 0 && expr2 > 0 || expr1 <= 0 && expr2 < 0);
        }
        public static bool operator ==(in FracNum fn1, in FracNum fn2) 
        {
            Logger a = new Logger("Equal"/*, Enable*/);
            a.Dispose();
            return (fn1.Numerator == fn2.Numerator && fn1.Denominator == fn2.Denominator);
        }
        public static bool operator !=(in FracNum fn1, in FracNum fn2)
        {
            Logger a = new Logger("Not equal"/*, Enable*/);
            a.Dispose();
            return !(fn1.Numerator == fn2.Numerator && fn1.Denominator == fn2.Denominator);
        }
        public static bool operator <=(in FracNum fn1, in FracNum fn2) 
        {
            Logger a = new Logger("Less or equal"/*, Enable*/);
            double expr1 = fn1.Numerator * fn2.Denominator - fn2.Numerator * fn1.Denominator;
            double expr2 = fn1.Denominator * fn2.Denominator;
            a.Dispose();
            return (expr1 <= 0 && expr2 > 0 || expr1 >= 0 && expr2 < 0);
        }
        public static bool operator <(in FracNum fn1, in FracNum fn2)
        {
            Logger a = new Logger("Less"/*, Enable*/);
            double expr1 = fn1.Numerator * fn2.Denominator - fn2.Numerator * fn1.Denominator;
            double expr2 = fn1.Denominator * fn2.Denominator;
            a.Dispose();
            return (expr1 < 0 && expr2 > 0 || expr1 > 0 && expr2 < 0);
        }

    }
    
}
