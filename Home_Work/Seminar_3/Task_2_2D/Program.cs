// 2. Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.

string enterAX = "Ax";
string enterAY = "Ay";
string enterAZ = "Az";
string enterBX = "Bx";

double GetValue(string text)
{
    string getValue = String.Empty;
    double value = 0;
    bool correct = false;
    while (!correct)
    {
        System.Console.Write($"Enter the {text}:");
        getValue = System.Console.ReadLine()!;
        correct = double.TryParse(getValue, out value);
    }
    return value;
}

double Pifagor(double ax, double bx, double ay, double by)
{
    return System.Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));
}

double Ax = GetValue(enterAX);
double Ay = GetValue(enterAY);
double Az = GetValue(enterAZ);
double Bx = GetValue(enterBX);

double result = Pifagor(Ax, Ay,Az,Bx);
System.Console.WriteLine(result);