// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.

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

void FillTwoDimensionalArray(int[,] mass, int arg1, int arg2)
{
    for (int i = 0; i < arg1; i++)
    {
        for (int j = 0; j < arg2; j++)
        {
            mass[i, j] = new System.Random().Next(0, 100);
        }
    }
}

string PrintTwoArray(int[,] array, int rowsMass, int columnsMass)
{
    string print = string.Empty;
    for (int i = 0; i < rowsMass; i++)
    {
        for (int j = 0; j < columnsMass; j++)
        {
            print += $"{array[i, j], 2} ";
        }
        print += System.Environment.NewLine;
    }
    return print;
}

void OrderingElements(int[,] array, int rows, int columns, int amount)
{
    int meaning = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int x = 0; x < columns; x++)
            {
                if (array[i, j] < array[i, x])
                {
                    meaning = array[i, j];
                    array[i, j] = array[i, x];
                    array[i, x] = meaning;
                }
            }
        }
    }
}

void Main()
{
    string enterM = "specify the number of array rows";
    string enterN = "specify the number of array columns";
    int M = GetValueNullNatural(enterM);
    int N = GetValueNullNatural(enterN);
    int[,] array = new int[M, N];
    int col = array.Length;
    FillTwoDimensionalArray(array, M, N);
    System.Console.WriteLine(PrintTwoArray(array, M, N));
    System.Console.WriteLine();
    OrderingElements(array, M, N, col);
    System.Console.WriteLine(PrintTwoArray(array, M, N));
}

Main();