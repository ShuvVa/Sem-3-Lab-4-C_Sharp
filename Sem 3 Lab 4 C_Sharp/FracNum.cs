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
        public FracNum(string name = "FracNum") : base(name)
        {
            Numerator = 0;
            Denominator = 1;
            Nod = 0;
        }
        public FracNum(double num, double denum, string str = "FracNum2") : base(str)
        {
            try
            {
                if (denum == 0) throw new MathIError("division by zero", num, denum, '/');
            }
            catch (MathIError exception)
            {
                Console.Write($"ERROR: ({ Convert.ToString(exception.what())})!");
                Environment.Exit(0);
            }

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
        public void GetFracNum()    //Аналог оператора ввода из C++
        {
            Logger a = new Logger ("GetFracNum");
            string num1 = "", num2 = "";
            try
            {
                Console.Write("Numerator:\n: ");
                num1 = Console.ReadLine();
                Console.Write("Denominator:\n: ");
                num2 = Console.ReadLine();

                for (int i = 0; i < num1.Length; i++)
                {
                    if ((num1[i] < Convert.ToChar(48) || num1[i] > Convert.ToChar(57)) && (num1[i] != Convert.ToChar(43)) && (num1[i] != Convert.ToChar(45)))
                    {
                        throw new InputIError("input error", "wrong char");
                    }
                }

                for (int i = 0; i < num2.Length; i++)
                {
                    if ((num2[i] < Convert.ToChar(48) || num2[i] > Convert.ToChar(57)) && (num2[i] != Convert.ToChar(43)) && (num2[i] != Convert.ToChar(45)))
                    {
                        throw new InputIError("input error", "wrong char");
                    }
                }

            }
            catch (InputIError exception)
            {
                Console.Write($"ERROR: ({ Convert.ToString(exception.what())})");
                Environment.Exit(0);
            }
            this.Numerator = Convert.ToDouble(num1);
            this.Denominator = Convert.ToDouble(num2);
            Console.WriteLine();
            a.Dispose();
        }

        //Аналог оператора присваивания из C++
        public FracNum GetFracNum(in FracNum fn)    
        {
            this.Numerator = fn.Numerator;
            this.Denominator = fn.Denominator;
            return this;
        }
        //Аналог оператора вывода из C++
        public string ReturnFracNum()   
        {
            Logger a = new Logger ("ReturnFracNum");
            string fracnum = ($"{this.Numerator}/{this.Denominator}");
            a.Dispose();
            return fracnum;
        }
        //Арифметические операторы
        public static FracNum operator +(in FracNum fn1, in FracNum fn2) 
        {
            Logger a = new Logger("Addition FracNum");
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
            Logger a = new Logger("Substraction FracNum");
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
            Logger a = new Logger("Multiplication FracNum");
            FracNum fn3 = new FracNum(fn1.Numerator*fn2.Numerator,fn1.Denominator*fn2.Denominator);
            a.Dispose();
            return fn3;
        }
        public static FracNum operator /(in FracNum fn1, in FracNum fn2) 
        {
            Logger a = new Logger("Division Fracum");
            FracNum fn3 = new FracNum(fn1.Numerator*fn2.Denominator,fn1.Denominator*fn2.Numerator);
            a.Dispose();
            return fn3;
        }
        public static FracNum operator ^(in FracNum fn, in int power) 
        {
            Logger a = new Logger("Power");
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

        public static FracNum operator +(in FracNum fn, in int inc)
        {
            Logger a = new Logger("Addition int");
            FracNum fn2 = new FracNum(fn.Numerator+inc*fn.Denominator,fn.Denominator);
            a.Dispose();
            return fn2;
        }

        public static FracNum operator -(in FracNum fn, in int dec)
        {
            Logger a = new Logger("Substracion int");
            FracNum fn2 = new FracNum(fn.Numerator-dec*fn.Denominator,fn.Denominator);
            a.Dispose();
            return fn2;
        }

        public static FracNum operator *(in FracNum fn, in int mul)
        {
            Logger a = new Logger("Multiplication int");
            FracNum fn2  = new FracNum(fn.Numerator*mul,fn.Denominator);
            a.Dispose();
            return fn2;
        }

        public static FracNum operator /(in FracNum fn, in int div)
        {
            Logger a = new Logger("Multiplication int");
            FracNum fn2  = new FracNum(fn.Numerator,fn.Denominator*div);
            a.Dispose();
            return fn2;
        }
        //Логические операторы
        public static bool operator >(in FracNum fn1, in FracNum fn2) 
        {
            Logger a = new Logger("More");
            double expr1 = fn1.Numerator * fn2.Denominator - fn2.Numerator * fn1.Denominator;
            double expr2 = fn1.Denominator * fn2.Denominator;
            a.Dispose();
            return (expr1 > 0 && expr2 > 0 || expr1 < 0 && expr2 < 0);
        }
        public static bool operator >=(in FracNum fn1, in FracNum fn2)
        {
            Logger a = new Logger("More or equal");
            double expr1 = fn1.Numerator * fn2.Denominator - fn2.Numerator * fn1.Denominator;
            double expr2 = fn1.Denominator * fn2.Denominator;
            a.Dispose();
            return (expr1 >= 0 && expr2 > 0 || expr1 <= 0 && expr2 < 0);
        }
        public static bool operator ==(in FracNum fn1, in FracNum fn2) 
        {
            Logger a = new Logger("Equal");
            a.Dispose();
            return (fn1.Numerator == fn2.Numerator && fn1.Denominator == fn2.Denominator);
        }
        public static bool operator !=(in FracNum fn1, in FracNum fn2)
        {
            Logger a = new Logger("Not equal");
            a.Dispose();
            return !(fn1.Numerator == fn2.Numerator && fn1.Denominator == fn2.Denominator);
        }
        public static bool operator <=(in FracNum fn1, in FracNum fn2) 
        {
            Logger a = new Logger("Less or equal");
            double expr1 = fn1.Numerator * fn2.Denominator - fn2.Numerator * fn1.Denominator;
            double expr2 = fn1.Denominator * fn2.Denominator;
            a.Dispose();
            return (expr1 <= 0 && expr2 > 0 || expr1 >= 0 && expr2 < 0);
        }
        public static bool operator <(in FracNum fn1, in FracNum fn2)
        {
            Logger a = new Logger("Less");
            double expr1 = fn1.Numerator * fn2.Denominator - fn2.Numerator * fn1.Denominator;
            double expr2 = fn1.Denominator * fn2.Denominator;
            a.Dispose();
            return (expr1 < 0 && expr2 > 0 || expr1 > 0 && expr2 < 0);
        }

    }
    
}
