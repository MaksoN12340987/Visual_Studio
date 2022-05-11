// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

string enter = "Enter the number";
string valueEnter = "To what power should a number be raised?";

double GetValueNullNatural(string text)
{
    string getValue = "";
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

double ObtainingDegree(double number,double degree)
{
    if (degree > 1)
    {
        degree--;
        for (int i = 0; i < degree; i++)
        {
            number *= number;
        }
    }
    return number;
}

double result = Math.Pow(GetValueNullNatural(enter), GetValueNullNatural(valueEnter));
System.Console.WriteLine(ObtainingDegree(GetValueNullNatural(enter), GetValueNullNatural(valueEnter)));
System.Console.WriteLine();