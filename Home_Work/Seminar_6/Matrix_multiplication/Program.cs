// Найти произведение двух матриц

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

void PrintTwoArray(int[,] massive, int arg1, int arg2)
{
    for (int i = 0; i < arg1; i++)
    {
        for (int j = 0; j < arg2; j++)
        {
            System.Console.Write($"{massive[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void AdditionMatrix(int[,] matrix1, int arg1, int arg2, int[,] matrix2, int arg4, int[,] matrixTotal)
{
    for (int i = 0; i < arg1; i++)
    {
        for (int j = 0; j < arg4; j++)
        {
            for (int z = 0; z < arg2; z++)
            {
                matrixTotal[i,j] += matrix1[i,z] * matrix2[z,i];
            }
        }
    }
} 

void FillTwoDimensionalArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new System.Random().Next(0, 10);
        }
    }
}

void Main()
{
    System.Console.WriteLine();
    string enterM1 = "specify the number of array rows";
    string enterN2 = "specify the number of array columns";
    int M1 = GetValueNullNatural(enterM1);
    int N2 = GetValueNullNatural(enterN2);
    System.Console.WriteLine();
    string enterM3 = "specify the number of array rows";
    string enterN4 = "specify the number of array columns";
    int M3 = GetValueNullNatural(enterM3);
    int N4 = GetValueNullNatural(enterN4);

    int[,] array1 = new int[M1, N2];
    int[,] array2 = new int[M3, N4];
    FillTwoDimensionalArray(array1);
    FillTwoDimensionalArray(array2);
    int[,] total = new int[M1, N4];

    AdditionMatrix(array1, M1, N2, array2, N4, total);
    PrintTwoArray(array1, M1, N2);
    PrintTwoArray(array2, M3, N4);
    PrintTwoArray(total, M1, N4);
}

Main();