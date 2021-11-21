using System;

namespace Program
{
    class Program
    {
        static void FracNumTest()
        {
            FracNum a = new FracNum() ,b = new FracNum();
            a.GetFracNum();
            b.GetFracNum();
            int x = 5;
            Console.WriteLine($"a = {a.ReturnFracNum()}");
            Console.WriteLine($"b = {b.ReturnFracNum()}");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"(a+b) = {(a + b).ReturnFracNum()}");
            Console.WriteLine($"(a-b) = {(a - b).ReturnFracNum()}");
            Console.WriteLine($"(a*b) = {(a * b).ReturnFracNum()}");
            Console.WriteLine($"(a/b) = {(a / b).ReturnFracNum()}");

            Console.WriteLine($"(a+x) = {(a + x).ReturnFracNum()}");
            Console.WriteLine($"(a-x) = {(a - x).ReturnFracNum()}");
            Console.WriteLine($"(a*x) = {(a * x).ReturnFracNum()}");
            Console.WriteLine($"(a/x) = {(a / x).ReturnFracNum()}");

            Console.WriteLine($"(b+x) = {(b + x).ReturnFracNum()}");
            Console.WriteLine($"(b-x) = {(b - x).ReturnFracNum()}");
            Console.WriteLine($"(b*x) = {(b * x).ReturnFracNum()}");
            Console.WriteLine($"(b/x) = {(b / x).ReturnFracNum()}");
            FracNum c = new FracNum();
            Console.WriteLine($"(c=a) = {(c=a).ReturnFracNum()}");
            Console.WriteLine($"(a^x) = {(a ^ x).ReturnFracNum()}");
            Console.WriteLine($"(b^x) = {(b ^ x).ReturnFracNum()}");
            Console.WriteLine($"(a^-1) = {(a ^ -1).ReturnFracNum()}");
            Console.WriteLine($"(b^-1) = {(b ^ -1).ReturnFracNum()}");
            Console.WriteLine($"(a>b) = {a > b}");
            Console.WriteLine($"(a>=b) = {a >= b}");
            Console.WriteLine($"(a==b) = {a == b}");
            Console.WriteLine($"(a!=b) = {a != b}");
            Console.WriteLine($"(a<=b) = {a <= b}");
            Console.WriteLine($"(a<b) = {a < b}");
        }
        static void Main(string[] args)
        {
            //Logger logger = new Logger("Main",true);
            //new Enable_Logger(true);
            //Logger.Enable = true;
            //FracNumTest();
            Console.Write("Выберите, включить ли логгер для программы или нет:\n1. Да.\n2. Нет.\n: ");
            string _choice = "";
            try
            {
                _choice = Console.ReadLine();

                for (int i = 0; i < _choice.Length; i++)
                {
                    if ((_choice[i] < Convert.ToChar(48) || _choice[i] > Convert.ToChar(57)) && (_choice[i] != Convert.ToChar(43)) && (_choice[i] != Convert.ToChar(45)))
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
            int choice = Convert.ToInt32(_choice);
            switch (choice) {
                case 1:
                    {
                        Logger.Enable = true;
                        break;
                    }
                case 2:
                    {
                        Logger.Enable = false;
                        break;
                    }
            }
            Console.WriteLine("Запуск функции для работы с дробями");
            FracNumTest();
            //string _choice;
            //try
            //{

            //    cin >> _choice;
            //    for (int i = 0; i < _choice.size(); i++)
            //        if (_choice[i] < 48 || _choice[i] > 57) throw InputIError("input error", "wrong char");
            //        else if ((_choice != "1") && (_choice != "2")) throw InputIError("input error", "wrong variant");

            //}

            //catch (InputIError&exception) {
            //    cerr << "ERROR: (" << exception.what() << ")\n";
            //    while (true)
            //    {

            //        Console.WriteLine("Вы неверно ввели номер варианта. Повторите попытку:\n: ";
            //        cin >> _choice;
            //        if ((_choice == "1") || (_choice == "2")) break;
            //    }
            //}

            //switch (stoi(_choice))
            //{
            //    case 1:
            //        {
            //            Enable = 1;
            //            break;
            //        }
            //    default:
            //        {
            //            break;
            //        }
            //}

            //Console.WriteLine("\nВыберите, какое задание включить:\n1. Работа с дробями.\n2. Игра.\n: ");
            //try
            //{

            //    cin >> _choice;
            //    for (int i = 0; i < _choice.size(); i++)
            //        if (_choice[i] < 48 || _choice[i] > 57) throw InputIError("input error", "wrong char");
            //        else if ((_choice != "1") && (_choice != "2")) throw InputIError("input error", "wrong variant");
            //}

            //catch (InputIError&exception) {
            //    cerr << "ERROR: (" << exception.what() << ")\n";
            //    while (true)
            //    {

            //        Console.WriteLine("Вы неверно ввели номер варианта. Повторите попытку:\n: ";
            //        cin >> _choice;
            //        if ((_choice == "1") || (_choice == "2")) break;
            //    }
            //}

            //switch (stoi(_choice))
            //{
            //    case 1:
            //        {
            //            FracNumTest();
            //            break;
            //        }
            //    default:
            //        {
            //            Console.Writeline("Wrong input");
            //        }
            //}


        }
    }
}