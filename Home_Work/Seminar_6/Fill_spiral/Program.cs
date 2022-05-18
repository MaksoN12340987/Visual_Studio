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

    while (x < amount) /*Цикл по номеру витка*/
    {
        y++;
        for (int j = y - 1; j < columns - y + 1; j++)
        {
            mass[y - 1, j] = z++;
            x++;
        }   /*Определение значений верхнего гор столбца*/

        for (int j = y; j < rows - y + 1; j++)
        {
            mass[j, columns - y] = z++;
            x++;
        }   /* --//-- По правому вертикальному столбцу*/

        for (int j = columns - y - 1; j >= y - 1; j--)
        {
            mass[rows - y, j] = z++;
            x++;
        }   /* --//-- по нижнему горизонтальному столбцу*/

        for (int j = rows - y - 1; j >= y; j--)
        {
            mass[j, y - 1] = z++;
            x++;
        }   /* --//-- по левому вертикальному столбцу*/

    }
    // -------------------------------------
    // int k = 1;
    // int x =0;
    // int y =0;
    // int z = rows;
    // int value = 1;
    // int counter = mass.Length / 4;
    // for (int i = 0; i < counter; i++)
    // {
    //     for (int a = x; a < columns; a++)
    //     {
    //         mass[x, a] += value;
    //     }
    //     for (int b = y; b < rows; b++)
    //     {
    //         mass[b, columns] += value;
    //     }
    //     x = columns;
    //     // while (x > y)
    //     // {
    //     //     mass[rows, x] += value;
    //     //     x--;
    //     // }
    //     // z = rows;
    //     // while (z > k)
    //     // {
    //     //     mass[z, x] += value;
    //     //     z--;
    //     // }
    //     x++;
    //     y++;
    //     k++;
    //     columns--;
    //     rows--;
    // }
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