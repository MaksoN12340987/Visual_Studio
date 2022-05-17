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
                mass[i,k] = 1;
            }
            if (i > 0)
            {
                mass[i,kd] = 1;
            }
        }
        k++;
    }
    int kp = 1;
    for (int r = 1; r < arg1; r++)
    {
        for (int c = 1; c < arg2; c++)
        {
            mass[r,c] = mass[k,kd] + mass[k,kp];
        }
    }
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

void Main()
{
    string enterM = "";
    int C = GetValueNullNatural(enterM);
    int[,] array = new int[C, C];
    FillTwoDimensionalArray(array, C, C);
    PrintTwoArray(array);
}

Main();