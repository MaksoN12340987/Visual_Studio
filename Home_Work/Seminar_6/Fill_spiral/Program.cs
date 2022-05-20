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
    int x = 0, y = 0, z = 1;

    while (x < amount)
    {
        y++;
        for (int j = y - 1; j < columns - y + 1; j++)
        {
            mass[y - 1, j] = z++;
            x++;
        }

        for (int j = y; j < rows - y + 1; j++)
        {
            mass[j, columns - y] = z++;
            x++;
        }

        for (int j = columns - y - 1; j >= y - 1; j--)
        {
            mass[rows - y, j] = z++;
            x++;
        }

        for (int j = rows - y - 1; j >= y; j--)
        {
            mass[j, y - 1] = z++;
            x++;
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