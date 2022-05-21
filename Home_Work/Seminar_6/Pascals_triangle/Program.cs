// Показать треугольник Паскаля 
// *Сделать вывод в виде равнобедренного треугольника 
// *Показать только нечетные числа в треугольнике

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

int GetValueOptions(string text, int ind)
{
    ind++;
    string getValue = String.Empty;
    int valueText = 0;
    bool correct = false;
    System.Console.WriteLine("[1] - Вывод равнобедренного треугольника Паскаля");
    System.Console.WriteLine("[2] - Показать только нечетные числа в треугольнике");
    System.Console.WriteLine("[3] - Вывести секретную фигуру(?__?)");
    System.Console.WriteLine("[4] - Завершить работу");
    while (!correct)
    {
        bool control = false;
        System.Console.Write($"Enter the {text}:");
        getValue = System.Console.ReadLine()!;
        control = int.TryParse(getValue, out valueText);
        if (control == true)
        {
            if (valueText != 0 && valueText < ind)
            {
                correct = true;
            }
        }
    }
    return valueText;
}

void FillTwoDimensionalArray(int[,] mass, int arg1, int arg2)
{
    int k = 0;
    int kd = 0;
    for (int i = 0; i < arg1; i++)
    {
        for (int j = 0; j < arg2; j++)
        {
            if (i == k)
            {
                mass[i, k] = 1;
            }
            if (i > 0)
            {
                mass[i, kd] = 1;
            }
        }
        k++;
    }
    for (int r = 1; r < arg1; r++)
    {
        for (int c = 1; c < arg2; c++)
        {
            if (mass[r, c] == 0)
            {
                mass[r, c] = mass[r - 1, c - 1] + mass[r - 1, c];
            }
        }
    }
}

void PrintTwoArrayIf(int[,] massive, int rowsMass, int columnsMass, int length)
{
    int height = 1;
    int width = columnsMass * 2;
    for (int i = 0; i < rowsMass; i++)
    {
        System.Console.SetCursorPosition(width, height);
        for (int j = 0; j < columnsMass; j++)
        {
            if (massive[i, j] != 0)
            {
                System.Console.Write($"{massive[i, j],4}"); ;
            }
        }
        height++;
        width -= 2;
        System.Console.WriteLine();
    }
}

void PrintTwoArrayIfOdd(int[,] massive, int rowsMass, int columnsMass, int length)
{
    int height = 1;
    int width = columnsMass * 3;
    for (int i = 0; i < rowsMass; i++)
    {
        System.Console.SetCursorPosition(width, height);
        for (int j = 0; j < columnsMass; j++)
        {
            if (massive[i, j] % 2 != 0)
            {
                System.Console.Write($"{massive[i, j],6}"); ;
            }
            else
            {
                System.Console.Write("      ");
            }
        }
        height++;
        width -= 3;
        System.Console.WriteLine();
    }
}

void PrintTwoArraySecret(int[,] massive, int rowsMass, int columnsMass, int length)
{
    int height = 1;
    int width = columnsMass * 2;
    for (int i = 0; i < rowsMass; i++)
    {
        System.Console.SetCursorPosition(width, height);
        for (int j = 0; j < columnsMass; j++)
        {
            if (massive[i, j] % 2 != 0)
            {
                System.Console.Write("$");
            }
            else
            {
                System.Console.Write(" ");
            }
        }
        height++;
        width -= 2;
        System.Console.WriteLine();
    }
}

void Main()
{
    string enterM = "";
    int C = GetValueNullNatural(enterM);
    int[,] array = new int[C, C];
    int col = array.Length;
    FillTwoDimensionalArray(array, C, C);

    int indicator = 4;
    string enterValue = "";
    int value = GetValueOptions(enterValue, indicator);
    while (value < indicator)
    {
        if (value == 1)
        {
            System.Console.Clear();
            PrintTwoArrayIf(array, C, C, col);
        }
        if (value == 2)
        {
            System.Console.Clear();
            PrintTwoArrayIfOdd(array, C, C, col);
        }
        if (value == 3)
        {
            System.Console.Clear();
            PrintTwoArraySecret(array, C, C, col);
        }
        value = GetValueOptions(enterValue, indicator);
    }
    System.Console.WriteLine("Thank you!");
}

Main();