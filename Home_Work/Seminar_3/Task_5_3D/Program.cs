// 5.Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

string enterAX = "Ax";
string enterAY = "Ay";
string enterAZ = "Az";
string enterBX = "Bx";
string enterBY = "By";
string enterBZ = "Bz";

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

double Pifagor(double ax, double ay, double az, double bx, double by, double bz)
{
    return System.Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2)) + Math.Pow(az - bz, 2);
}

double Ax = GetValue(enterAX);
double Ay = GetValue(enterAY);
double Az = GetValue(enterAZ);
double Bx = GetValue(enterBX);
double By = GetValue(enterBY);
double Bz = GetValue(enterBZ);

double result = Pifagor(Ax, Ay,Az,Bx,By,Bz);
System.Console.WriteLine(result);