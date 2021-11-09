using System;
using Logger;
using FracNum;
using IError;
using Game;

namespace Sem_3_Lab_4_C_Sharp
{
    class Program
    {
        static void FracNumTest()
        {
            
        }
        static void Main(string[] args)
        {
            FracNumTest();
        }
    }
}
//==============================================================================
//Main.cpp
//#include <iostream>
//#include <math.h>
//#include <vector>

//#include "FracNum.h"
//#include "Game.h"
//#include "IError.h"
//#include "Logger.h"

//using namespace std;

//void FracNumTest()
//{
//	FracNum a, b;
//	cin >> a;
//	cin >> b;
//	int x = -5;
//	cout << "a = " << a << endl;
//	cout << "b = " << b << endl;
//	cout << "x = " << x << endl;
//	cout << "(a+b) = " << (a + b) << endl;
//	cout << "(a-b) = " << (a - b) << endl;
//	cout << "(a*b) = " << (a * b) << endl;
//	cout << "(a^x) = " << (a ^ x) << endl;
//	cout << "(b^x) = " << (b ^ x) << endl;
//	FracNum c = a;
//	cout << "(a=b) = " << (a = b) << endl;
//	a = c;
//	cout << "(a>b) = " << (a > b) << endl;
//	cout << "(a>=b) = " << (a >= b) << endl;
//	cout << "(a==b) = " << (a == b) << endl;
//	cout << "(a<=b) = " << (a <= b) << endl;
//	cout << "(a<b) = " << (a < b) << endl;
//}

//int main()
//{

//	setlocale(LC_ALL, "Rus");
//	Logger main("main");
//	cout << "Выберите, включить ли логгер для программы или нет:\n1. Да.\n2. Нет.\n: ";
//	string _choice;
//	try
//	{

//		cin >> _choice;
//		for (int i = 0; i < _choice.size(); i++)
//			if (_choice[i] < 48 || _choice[i] > 57) throw InputIError("input error", "wrong char");
//			else if ((_choice != "1") && (_choice != "2")) throw InputIError("input error", "wrong variant");

//	}

//	catch (InputIError&exception) {
//		cerr << "ERROR: (" << exception.what() << ")\n";
//		while (true)
//		{

//			cout << "Вы неверно ввели номер варианта. Повторите попытку:\n: ";
//			cin >> _choice;
//			if ((_choice == "1") || (_choice == "2")) break;
//		}
//	}

//	switch (stoi(_choice))
//	{
//		case 1:
//			{
//				Enable = 1;
//				break;
//			}
//		default:
//			{
//				break;
//			}
//	}

//	cout << "\nВыберите, какое задание включить:\n1. Работа с дробями.\n2. Игра.\n: ";
//	try
//	{

//		cin >> _choice;
//		for (int i = 0; i < _choice.size(); i++)
//			if (_choice[i] < 48 || _choice[i] > 57) throw InputIError("input error", "wrong char");
//			else if ((_choice != "1") && (_choice != "2")) throw InputIError("input error", "wrong variant");
//	}

//	catch (InputIError&exception) {
//		cerr << "ERROR: (" << exception.what() << ")\n";
//		while (true)
//		{

//			cout << "Вы неверно ввели номер варианта. Повторите попытку:\n: ";
//			cin >> _choice;
//			if ((_choice == "1") || (_choice == "2")) break;
//		}
//	}

//	switch (stoi(_choice))
//	{
//		case 1:
//			{
//				FracNumTest();
//				break;
//			}
//		default:
//			{
//				FunnyGame Game;
//			}
//	}

//	}
//==============================================================================
//Logger.h
//#pragma once
//#include <string>

//using namespace std;

//extern bool Enable;

//class Logger
//{
//    public:
//    bool enable;
//    Logger(const string& str, const bool _enable = false);

//    ~Logger();
//    void OutFuctName(string name, const bool _enable);

//    string nameClass;
//};
//==============================================================================
//Logger.cpp
//#include <iostream>
//#include <string>
//#include "Logger.h"

//using namespace std;

//bool Enable = false;

//Logger::Logger(const string& str, const bool _enable) : nameClass(str, _enable)
//{
//    Enable = _enable;
//    if (Enable) cout << endl << "Construct " << str << endl;
//}

//Logger::~Logger()
//{
//    if (Enable) cout << endl << "Destruct " << nameClass << endl;
//}

//void Logger::OutFuctName(string name, const bool _enable)
//{
//    if (_enable) cout << "Function " << name << " begin to work." << endl;
//}
//==============================================================================
//IError.h
//#pragma once
//#include <iostream>
//#include <fstream>
//#include <string>

//using namespace std;

//class IError
//{
//    protected:
//    string m_IError;
//    public:
//    IError(string error) : m_IError(error) { }
//    string what() const noexcept
//    {
//        return m_IError;
//    }

//~IError();

//};

//class MathIError : public IError
//{
//private:
//    string m_mathIError;
//public:
//    MathIError(string error, int a, int b, char op);

//string what() const noexcept;
//};

//class InputIError : public IError
//{
//private:
//    string m_inputIError;
//public:
//    InputIError(string error, string inputtext);

//string what() const noexcept;

//};
//==============================================================================
//IError.cpp
//#include "IError.h"

//IError::~IError()
//{
//    ofstream f("error.txt", ios::app);
//    f << "Error: " << m_IError << endl;
//    f.close();
//}

//MathIError::MathIError(string error, int a, int b, char op) : IError(error) {
//    m_mathIError = to_string(a) + " " + op + " " + to_string(b);
//}

//string MathIError::what() const noexcept {
//    string error = m_IError + " : " + m_mathIError;
//return error;
//}

//InputIError::InputIError(string error, string inputtext) : IError(error) {
//    m_inputIError = inputtext;
//}

//string InputIError::what() const noexcept {
//    string error = m_IError + " : " + m_inputIError;
//return error;
//}

//FracNum.h
//#pragma once
//#include <iostream>
//#include <math.h>
//#include <vector>

//#include "Logger.h"

//using namespace std;

//int GCD(int x, int y);  //Нахождение НОД

//class FracNum
//{    //Класс работы с дробями
//    private:
//    double Numerator;       //Числитель
//    double Denominator;     //Знаменатель
//    double Nod;             //НОД (наибольшй общий делитель)
//    public:
//    Logger logger;
//    FracNum();
//    FracNum(double num, double denum);
//    ~FracNum();
//    //Операторы ввода и вывода
//    friend istream& operator>>(istream& is, FracNum& fn);
//    friend ostream& operator<<(ostream& os, const FracNum& fn);
//    //Арифметические операторы
//    friend FracNum operator+(const FracNum& fn1, const FracNum& fn2);
//    friend FracNum operator-(const FracNum& fn1, const FracNum& fn2);
//    friend FracNum operator*(const FracNum& fn1, const FracNum& fn2);
//    friend FracNum operator/(const FracNum& fn1, const FracNum& fn2);
//    friend FracNum operator^(const FracNum& fn, int power);
//    FracNum& operator= (const FracNum& fn1);
//    //Логичекие операторы
//    friend bool operator >(const FracNum& fn1, const FracNum& fn2);
//    friend bool operator >=(const FracNum& fn1, const FracNum& fn2);
//    friend bool operator ==(const FracNum& fn1, const FracNum& fn2);
//    friend bool operator <=(const FracNum& fn1, const FracNum& fn2);
//    friend bool operator <(const FracNum& fn1, const FracNum& fn2);
//};





//istream& operator >>(istream& is, FracNum& fn);
//ostream& operator <<(ostream& os, const FracNum& fn);

//FracNum operator +(const FracNum& fn1, const FracNum& fn2);
//FracNum operator -(const FracNum& fn1, const FracNum& fn2);
//FracNum operator *(const FracNum& fn1, const FracNum& fn2);
//FracNum operator /(const FracNum& fn1, const FracNum& fn2);
//FracNum operator ^(const FracNum& fn, int power);

//bool operator >(const FracNum& fn1, const FracNum& fn2);
//bool operator >=(const FracNum& fn1, const FracNum& fn2);
//bool operator ==(const FracNum& fn1, const FracNum& fn2);
//bool operator <(const FracNum& fn1, const FracNum& fn2);
//bool operator <=(const FracNum& fn1, const FracNum& fn2);
//==============================================================================
//FracNum.cpp
//#include "FracNum.h"
//#include "IError.h"

//int GCD(int x, int y)
//{
//    return y ? GCD(y, x % y) : x;
//}

//FracNum::FracNum() : logger("FracNum", Enable) {
//    Numerator = 0;
//    Denominator = 1;
//    Nod = 0;
//}

//FracNum::FracNum(double num, double denum) : logger("FracNum2", Enable) {

//    try
//    {
//        if (denum == 0)
//            throw MathIError("division by zero", num, denum, '/');
//    }
//    catch (MathIError&exception)
//    {
//        cerr << "ERROR: (" << exception.what() << ")\n";
//        num = 0;
//        denum = 1;
//        abort();
//    }

//    Numerator = num;

//    Denominator = denum;

//    Nod = GCD(Numerator, Denominator);
//    Numerator /= Nod;
//    Denominator /= Nod;
//    if (Denominator < 0)
//    {
//        Numerator *= -1;
//        Denominator *= -1;
//    }
//    }

//    FracNum::~FracNum() {
//        Numerator = 0;
//        Denominator = 0;
//        Nod = 0;

//    }

//    istream & operator>> (istream & is, FracNum & fn) {
//        Logger a("Input", Enable);
//        string num1, num2;
//        try
//        {
//            if (&is == &cin)
//                cout << "Numerator:\n: ";
//        is >> num1;
//            if (&is == &cin)
//                cout << "Denominator:\n: ";
//        is >> num2;



//            for (int i = 0; i < num1.size(); i++)
//            {
//                if ((num1[i] < 48 || num1[i] > 57) && (num1[i] != 43) && (num1[i] != 45))
//                {
//                    throw InputIError("input error", "wrong char");
//                }
//            }
//            for (int i = 0; i < num2.size(); i++)
//            {
//                if ((num2[i] < 48 || num2[i] > 57) && (num2[i] != 43) && (num2[i] != 45))
//                {
//                    throw InputIError("input error", "wrong char");
//                }
//            }
//        }
//        catch (InputIError&exception) {
//            cerr << "ERROR: (" << exception.what() << ")\n";
//            abort();
//        }
//        fn.Numerator = stoi(num1);
//        fn.Denominator = stoi(num2);
//        return is;
//        }

//        ostream & operator<< (ostream & os, const FracNum&fn) {
//            Logger a("Output", Enable);
//            os << fn.Numerator << "/" << fn.Denominator;
//            return os;
//        }

//        FracNum & FracNum::operator= (const FracNum&fn) {
//            Logger a("Define", Enable);
//            Denominator = fn.Denominator;
//            Numerator = fn.Numerator;
//            return *this;
//        }

//        FracNum operator+(const FracNum&fn1, const FracNum&fn2) {
//            Logger a("Addition", Enable);
//            if (fn1.Denominator == fn2.Denominator)
//            {
//                FracNum fn3(fn1.Numerator +fn2.Numerator, fn1.Denominator);
//                return fn3;
//            }
//            else
//            {
//                FracNum fn3((fn1.Numerator* fn2.Denominator) +(fn2.Numerator * fn1.Denominator), fn1.Denominator* fn2.Denominator);
//                return fn3;
//            }
//        }

//        FracNum operator-(const FracNum&fn1, const FracNum&fn2) {
//            Logger a("Subtraction", Enable);
//            if (fn1.Denominator == fn2.Denominator)
//            {
//                FracNum fn3(fn1.Numerator -fn2.Numerator, fn1.Denominator);
//                return fn3;
//            }
//            else
//            {
//                FracNum fn3((fn1.Numerator* fn2.Denominator) -(fn2.Numerator * fn1.Denominator), fn1.Denominator* fn2.Denominator);
//                return fn3;
//            }
//        }

//        FracNum operator*(const FracNum&fn1, const FracNum&fn2) {
//            Logger a("Multiplication", Enable);
//            FracNum fn3(fn1.Numerator* fn2.Numerator, fn1.Denominator* fn2.Denominator);
//            return fn3;
//        }

//        FracNum operator/ (const FracNum&fn1, const FracNum&fn2) {
//            Logger a("Division", Enable);
//            FracNum fn3(fn1.Numerator* fn2.Denominator, fn1.Denominator* fn2.Numerator);
//            return fn3;
//        }

//        FracNum operator^(const FracNum&fn, int power) {
//            Logger a("Power", Enable);
//            if (!power)
//            {
//                FracNum fn3(1,1);
//                return fn3;
//            }
//            else if (power == -1)
//            {
//                FracNum fn3(fn.Denominator, fn.Numerator);
//                return fn3;
//            }
//            else if (power < -1)
//            {
//                FracNum fn3(pow(fn.Denominator, abs(power)), pow(fn.Numerator, abs(power)));
//                return fn3;
//            }
//            else
//            {
//                FracNum fn3(pow(fn.Numerator, power), pow(fn.Denominator, power));
//                return fn3;
//            }
//        }



//        bool operator> (const FracNum&fn1, const FracNum&fn2) {
//            Logger a("More", Enable);
//            int expr1 = fn1.Numerator * fn2.Denominator - fn2.Numerator * fn1.Denominator;
//            int expr2 = fn1.Denominator * fn2.Denominator;
//            return (expr1 > 0 && expr2 > 0 || expr1 < 0 && expr2 < 0);
//        }

//        bool operator>= (const FracNum&fn1, const FracNum&fn2) {
//            Logger a("More or equal", Enable);
//            int expr1 = fn1.Numerator * fn2.Denominator - fn2.Numerator * fn1.Denominator;
//            int expr2 = fn1.Denominator * fn2.Denominator;
//            return (expr1 >= 0 && expr2 > 0 || expr1 <= 0 && expr2 < 0);
//        }

//        bool operator== (const FracNum&fn1, const FracNum&fn2) {
//            Logger a("Equal", Enable);
//            return (fn1.Numerator == fn2.Numerator && fn1.Denominator == fn2.Denominator);
//        }

//        bool operator< (const FracNum&fn1, const FracNum&fn2) {
//            Logger a("Less", Enable);
//            int expr1 = fn1.Numerator * fn2.Denominator - fn2.Numerator * fn1.Denominator;
//            int expr2 = fn1.Denominator * fn2.Denominator;
//            return (expr1 < 0 && expr2 > 0 || expr1 > 0 && expr2 < 0);
//        }

//        bool operator<= (const FracNum&fn1, const FracNum&fn2) {
//            Logger a("Less or equal", Enable);
//            int expr1 = fn1.Numerator * fn2.Denominator - fn2.Numerator * fn1.Denominator;
//            int expr2 = fn1.Denominator * fn2.Denominator;
//            return (expr1 <= 0 && expr2 > 0 || expr1 >= 0 && expr2 < 0);
//        }
//==============================================================================
//Game.h
//#pragma once
//#include <iostream>
//#include <vector>
//#include <string>
//#include <ctime>

//#include "Logger.h"

//using namespace std;

//const int TUTORIAL = 3;
//const int EASY = 10;
//const int AVERAGE = 15;
//const int HARD = 20;

//class FunnyGame
//{
//    private:
//	vector<vector<bool>> Row, PRow;
//    int Difficulty; //ѕеременна¤, отвечающа¤ за 
//    int count;
//    bool CheatMode;
//    public:
//	Logger logger;
//    FunnyGame(); //»нициализаци¤ игры
//    int Start(); //
//    void GridsResize(int num);
//    void RowFill(int num);
//    bool random();
//    void ShowPlayerGrid(int num);
//    void ShowGrids(int num);
//    void CheckDot(int num);
//    bool isWin(int num);	//‘ункци¤ дл¤ определени¤ победы
//};
//==============================================================================
//Game.cpp
//#include "Game.h"
//#include "IError.h"

//using namespace std;

//FunnyGame::FunnyGame() : logger("FunnyGame", Enable)
//{
//	srand(time(0));
//	Difficulty = Start();
//	GridsResize(Difficulty);
//	RowFill(Difficulty);
//	CheckDot(Difficulty);
//	isWin(Difficulty);
//}

//int FunnyGame::Start()
//{
//	Logger a("Start", Enable);
//	string choice;
//	cout << "Welcome to FunnyGame! \nYour goal is to guess the location of randomly generated points.\nThe number of points depends on the size of the field. \nFor example, if Grid is 5x5, the number of attempts is 5, the number of dots is 2 and you have to find only 1.\n\n";
//	cout << "Select game difficulty:\n1. Tutorial (Grid 3x3).\n2. Easy (Grid 10x10).\n3. Average (Grid 15x15).\n4. Hard (Grid 20x20).\n: ";
//	try
//	{

//		cin >> choice;
//		if (choice == "123454321") CheatMode = true;
//		for (int i = 0; i < choice.size(); i++)
//			if (choice[i] < 48 || choice[i] > 57) throw InputIError("input error", "wrong char");
//			else if ((choice != "1") && (choice != "2") && (choice != "3") && (choice != "4")) throw InputIError("input error", "wrong variant");

//	}

//	catch (InputIError&exception) {
//		cerr << "ERROR: (" << exception.what() << ")\n";
//		while (true)
//		{

//			cout << "You're entered the number of variant incorrectly. Please, try again:\n: ";
//			cin >> choice;
//			if ((choice == "1") || (choice == "2") || (choice == "3") || (choice == "4")) break;
//		}
//	}

//	switch (stoi(choice))
//	{
//		case 1:
//			{
//				return TUTORIAL;
//			}
//		case 2:
//			{
//				return EASY;
//			}
//		case 3:
//			{
//				return AVERAGE;
//			}
//		case 4:
//			{
//				return HARD;
//			}
//	}
//	}

//	void FunnyGame::GridsResize(int num) {
//		Logger a("Start", Enable);
//		Row.assign(num, vector<bool>(num));
//		PRow.assign(num, vector<bool>(num));
//	}

//	void FunnyGame::RowFill(int num){
//		Logger a("RowFill", Enable);

//		int x = 0, y = 0;
//		for (int i = 0; i < num / 2; i++)
//		{
//			do
//			{
//				x = rand() % (num);
//				y = rand() % (num);
//			} while (Row[x][y]);
//			Row[x][y] = true;
//		}


//	}

//	bool FunnyGame::random() {
//		Logger a("random", Enable);
//		return (rand() % 2 == 0);
//	}

//	void FunnyGame::ShowPlayerGrid(int num) {
//		Logger a("ShowPlayerGrid", Enable);

//		cout << endl << "\t\t ";


//		for (int i = 0; i < num; i++) cout << i << " ";
//		cout << endl << "\t\t ";

//		for (int i = 0; i < num; i++) cout << ((i < 10) ? "— " : "—— ");

//		cout << endl;
//		for (int i = 0; i < num; i++)
//		{
//			cout << "\t" << i << "\t|";
//			for (int j = 0; j < num; j++)
//			{
//				cout << PRow[i][j] << ((j < 9) ? " " : "  ");
//			}
//			cout << endl;
//		}
//		cout << endl << endl;
//	}

//	void FunnyGame::ShowGrids(int num) {
//		Logger a("ShowGrids", Enable);

//		cout << endl << "\t\t ";

//		for (int i = 0; i < num; i++) cout << i << " ";

//		cout << "\t   \t ";

//		for (int i = 0; i < num; i++) cout << i << " ";

//		cout << endl << "\t\t ";

//		for (int i = 0; i < num; i++) cout << ((i < 10) ? "— " : "—— ");

//		cout << "\t   \t ";

//		for (int i = 0; i < num; i++) cout << ((i < 10) ? "— " : "—— ");

//		cout << endl;
//		for (int i = 0; i < num; i++)
//		{
//			cout << "\t" << i << "\t|";
//			for (int j = 0; j < num; j++)
//			{
//				cout << Row[i][j] << ((j < 9) ? " " : "  ");
//			}
//			cout << "\t  " << i << "\t|";
//			for (int j = 0; j < num; j++)
//			{
//				cout << PRow[i][j] << ((j < 9) ? " " : "  ");
//			}
//			cout << endl;
//		}
//		cout << endl << endl;
//	}

//	void FunnyGame::CheckDot(int num) {
//		Logger a("CheckDot", Enable);
//		count = 0;
//		for (int i = 0; i < num; i++)
//		{
//			if (!CheatMode) ShowPlayerGrid(num);
//			else ShowGrids(num);
//			string x = "", y = "";


//			try
//			{
//				cout << "Enter X and Y coords:\nX: ";
//				cin >> x;
//				cout << "Y: ";
//				cin >> y;
//				for (int i = 0; i < x.size(); i++)
//					if (x[i] < 48 || x[i] > 57) throw InputIError("input error", "wrong char");


//				for (int i = 0; i < y.size(); i++)
//					if (y[i] < 48 || y[i] > 57) throw InputIError("input error", "wrong char");

//				if ((stoi(x) < 0) || (stoi(x) >= num) || (stoi(y) < 0) || (stoi(y) >= num)) InputIError("input error", "wrong coords");
//				else if (PRow[stoi(y)][stoi(x)]) InputIError("input error", "occupied coords");
//			}

//			catch (InputIError&exception) {
//			cerr << "ERROR: (" << exception.what() << ")\n";
//			while (true)
//			{
//				cout << "You're entered the coords incorrectly. Please, try again:\n: ";
//				cin >> x;
//				cout << ": ";
//				cin >> y;
//				cout << endl;
//				if ((stoi(x) >= 0) && (stoi(x) < num) && (stoi(y) >= 0) && (stoi(y) < num) && !PRow[stoi(y)][stoi(x)]) break;
//			}
//		}

//		PRow[stoi(y)][stoi(x)] = true;

//		if (Row[stoi(y)][stoi(x)]) count++;
//	}
//}

//bool FunnyGame::isWin(int num)
//{
//	Logger a("isWin", Enable);
//	ShowGrids(num);
//	if (count >= (num / 3)) { cout << "You won the game!\n"; return true; }
//	else { cout << "You lose the game!\n"; return false; }
//}