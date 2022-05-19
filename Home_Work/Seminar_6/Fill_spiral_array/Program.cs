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

void PrintTwoArray(int[,] massive, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            System.Console.Write($"{massive[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillTwoDimensionalArray(int[,] mass, int rows, int columns, int amount)
{
    int count = 0, k = 0, z = 1;

    while (count < amount)
    {
        k++;
        for (int a = k - 1; a < columns - k + 1; a++)
        {
            mass[k - 1, a] = z++;
            count++;
        }
        for (int b = k; b < rows - k + 1; b++)
        {
            mass[b, columns - k] = z++;
            count++;
        }
        for (int c = columns - k - 1; c >= k - 1; c--)
        {
            mass[rows - k, c] = z++;
            count++;
        }
        for (int d = rows - k - 1; d >= k; d--)
        {
            mass[d, k - 1] = z++;
            count++;
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
    FillTwoDimensionalArray(array, M, N, col);
    PrintTwoArray(array, M, N);
}

Main();