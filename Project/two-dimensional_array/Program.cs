// Показать двумерный массив размером m×n заполненный вещественными числами

string enterM = "specify the number of array rows";
string enterN = "specify the number of array columns";

int GetValueNullNatural(string text)
{
    string getValue = String.Empty;
    int value = 0;
    bool correct = false;
    while (!correct)
    {
        bool control = false;
        System.Console.Write($"Enter the {text}:");
        getValue = System.Console.ReadLine()!;
        control = int.TryParse(getValue, out value);
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

void FillTwoDimensionalArray(int[,] massive, int column, int line)
{
    int constant = 1;
    for (int i = 0; i < line; i++)
    {
        for (int iCol = 0; iCol < column; iCol++)
        {
            massive[iCol, i] += constant;
            constant++;
        }
    }
}

void PrintTwoArray(int[,] massiveNumbers, int column, int line)
{
    int indexColumn = 0;
    for (int i = 0; i < line; i++)
    {
        for (int iCol = 0; iCol < column; iCol++)
        {
            System.Console.Write(massiveNumbers[iCol, i]);
        }
        System.Console.WriteLine();
    }
}

int M =  GetValueNullNatural(enterM);
int N =  GetValueNullNatural(enterN);

int[,] array = new int[M,N];

FillTwoDimensionalArray(array, M, N);
PrintTwoArray(array, M, N);