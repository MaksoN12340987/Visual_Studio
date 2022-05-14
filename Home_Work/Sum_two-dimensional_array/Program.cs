// Найти произведение двух матриц

string enterMArg1 = "specify the number of array rows";
string enterNArg1 = "specify the number of array columns";
string enterMArg2 = "specify the number of array rows";
string enterNArg2 = "specify the number of array columns";

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

void FillTwoDimensionalArray(int[,] massive)
{
    int constant = 1;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] += constant;
            constant++;
        }
    }
}

int SizeRowsTwoArrays(int[,] massiveArg1, int[,] massiveArg2)
{
    return Math.Max(massiveArg1.GetLength(0), massiveArg2.GetLength(0));
}

int SizeColumnsTwoArrays(int[,] massiveArg1, int[,] massiveArg2)
{
    return Math.Max(massiveArg1.GetLength(1), massiveArg2.GetLength(1));
}

void PrintTwoArray(int[,] massiveNumbers)
{
    for (int i = 0; i < massiveNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < massiveNumbers.GetLength(1); j++)
        {
            System.Console.Write($"{massiveNumbers[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void ConvertTwoDimensionalArray(int[,] arg1, int[,] total)
{
    for (int i = 0; i < total.GetLength(0); i++)
    {
        for (int j = 0; j < total.GetLength(1); j++)
        {
            if(i < arg1.GetLength(0) && j < arg1.GetLength(1))
            {
                total[i, j] = arg1[i, j];
            }
        }
    }
}

void SumTwoDimensionalArray(int[,] arg1, int[,] arg2, int[,] sum)
{
    for (int i = 0; i < sum.GetLength(0); i++)
    {
        for (int j = 0; j < sum.GetLength(1); j++)
        {
            if (arg1[i, j] != 0 && arg2[i, j] != 0)
            {
                sum[i, j] = arg1[i, j] * arg2[i, j];
            }
            if(arg1[i, j] == 0)
            {
                sum[i, j] = arg2[i, j];
            }
            else
            {
                sum[i, j] = arg1[i, j];
            }
        }
    }
}

System.Console.WriteLine();
int[,] arrayArg1 = new int[GetValueNullNatural(enterMArg1), GetValueNullNatural(enterNArg1)];
System.Console.WriteLine();
int[,] arrayArg2 = new int[GetValueNullNatural(enterMArg2), GetValueNullNatural(enterNArg2)];

System.Console.WriteLine();

PrintTwoArray(arrayArg1);

System.Console.WriteLine();

PrintTwoArray(arrayArg2);

System.Console.WriteLine();

FillTwoDimensionalArray(arrayArg1);
FillTwoDimensionalArray(arrayArg2);

PrintTwoArray(arrayArg1);

System.Console.WriteLine();

PrintTwoArray(arrayArg2);

System.Console.WriteLine();

int M = SizeRowsTwoArrays(arrayArg1, arrayArg2);
int N = SizeColumnsTwoArrays(arrayArg1, arrayArg2);
int[,] arrayOne = new int[M,N];
int[,] arrayTwo = new int[M,N];
int[,] array = new int[M,N];

ConvertTwoDimensionalArray(arrayArg1, arrayOne);
ConvertTwoDimensionalArray(arrayArg2, arrayTwo);

PrintTwoArray(arrayOne);
PrintTwoArray(arrayTwo);

System.Console.WriteLine();

SumTwoDimensionalArray(arrayOne, arrayTwo, array);
PrintTwoArray(array);