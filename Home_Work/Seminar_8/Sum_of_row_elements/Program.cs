// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

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

void FillTwoDimensionalArray(int[,] mass, int arg1, int arg2)
{
    for (int i = 0; i < arg1; i++)
    {
        for (int j = 0; j < arg2; j++)
        {
            mass[i, j] = new System.Random().Next(0, 20);
        }
    }
}

string MinimumSumRowElements(int[,] array, int rows, int columns, int amount)
{
    int[] meaning = new int[rows];
    string total = string.Empty;
     for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            meaning[i] += array[i,j];
        }
    }
    int min = meaning[0];
    int indexMin = 0;
    for (int k = 0; k < rows; k++)
    {
        if (min > meaning[k])
        {
            min =  meaning[k];
            indexMin = k;
        }
    }
    return total = $"The row with the smallest sum of elements: {indexMin}, Sum: {min}";
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
    System.Console.WriteLine(MinimumSumRowElements(array, M, N, col));
}

Main();