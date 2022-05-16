// Спирально заполнить двумерный массив

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

void PrintTwoArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            System.Console.Write($"{massive[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillTwoDimensionalArray(int[,] mass)
{
    // 1   2  3 4
    // 10 11 12 5
    // 9   8  7 6
}

void Main()
{
    string enterM = "specify the number of array rows";
    string enterN = "specify the number of array columns";
    int M = GetValueNullNatural(enterM);
    int N = GetValueNullNatural(enterN);
    int[,] array = new int[M, N];
    
    PrintTwoArray(array);
}