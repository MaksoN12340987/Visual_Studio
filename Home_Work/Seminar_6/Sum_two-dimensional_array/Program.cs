// Найти произведение двух матриц

string enterMArg1 = "specify the number of array rows";
string enterNArg1 = "specify the number of array columns";
string enterMArg2 = "specify the number of array rows";
string enterNArg2 = "specify the number of array columns";

int GetValueNatural(string text)
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

void SumTwoDimensionalArray(int[,] arg1, int[,] arg2, int[,] sum)
{
    int k = 0;
    for (int i = 0; i < sum.GetLength(0); i++)
    {
        k = 0;
        for (int j = 0; j < sum.GetLength(1); j++)
        {
            sum[i, j] = arg1[i, k] * arg2[k, i];
            k++;
        }
    }
}

// matrRes[0, 0] = matrix1[0, 0] * matrix2[0, 0] +
//                 matrix1[0, 1] * matrix2[1, 0] +
//                 matrix1[0, 2] * matrix2[2, 0] +
//                 matrix1[0, 3] * matrix2[3, 0];
// System.Console.Write(matrRes[0, 0]+ " ");
// matrRes[0, 1] = matrix1[1, 0] * matrix2[0, 1] +
//                 matrix1[1, 1] * matrix2[1, 1] +
//                 matrix1[1, 2] * matrix2[2, 1] +
//                 matrix1[1, 3] * matrix2[3, 1];

System.Console.WriteLine("Specify the size of the first matrix");
int rows1 = GetValueNatural(enterMArg1);
int columns1 = GetValueNatural(enterNArg1);


System.Console.WriteLine("Specify the size of the second matrix");
int rows2 = GetValueNatural(enterMArg2);
int columns2 = GetValueNatural(enterNArg2);

if (columns1 == rows2)
{
    int[,] arrayArg1 = new int[rows1, columns1];
    int[,] arrayArg2 = new int[rows2, columns2];
    int[,] array = new int[rows1, columns2];



    FillTwoDimensionalArray(arrayArg1);
    FillTwoDimensionalArray(arrayArg2);

    System.Console.WriteLine();
    PrintTwoArray(arrayArg1);
    System.Console.WriteLine();
    PrintTwoArray(arrayArg2);
    System.Console.WriteLine();

    SumTwoDimensionalArray(arrayArg1, arrayArg2, array);
    PrintTwoArray(array);
}