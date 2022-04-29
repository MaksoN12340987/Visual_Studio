// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

string enterA = "X";
string enterB = "Y";

double GetValueNull(string text)
{
    string getValue = String.Empty;
    double value = 0;
    bool correct = false;
    while (!correct)
    {
        bool control = false;
        System.Console.Write($"Enter the {text}:");
        getValue = System.Console.ReadLine()!;
        control = double.TryParse(getValue, out value);
        if (control == true)
        {
            if (value != 0)
            {
                correct = true;
            }
        }
    }
    return value;
}

double QuarterNumber(double numberX, double numberY)
{
    double result = 1;
    if (numberX < 0)
    {
        if (numberY < 0)
        {
            result = 3;
        }
        else
        {
            result = 2;
        }
    }
    if (numberY < 0 & numberX > 0)
    {
        result = 4;
    }
    return result;
}

double X = GetValueNull(enterA);
double Y = GetValueNull(enterB);
double quarter = QuarterNumber(X, Y);
System.Console.WriteLine($"{quarter} quarter");

