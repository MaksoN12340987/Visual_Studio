// В двумерном массиве n×k заменить четные элементы на противоположные

// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

// В двумерном массиве показать позиции числа, заданного пользователем 
// или указать, что такого элемента нет

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

int GetValueOptions(string text, int ind)
{
    ind++;
    string getValue = String.Empty;
    int valueText = 0;
    bool correct = false;
    System.Console.WriteLine("[1] - Заменить четные элементы на противоположные");
    System.Console.WriteLine("[2] - Заменить элементы, у которых оба индекса чётные на их квадраты");
    System.Console.WriteLine("[3] - Вывести позицию заданного числа");
    // System.Console.WriteLine("[4] - Сумма элементов главной диагонали");
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

void ReplacementElementOpposite(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] % 2 == 0 && matrix[i, j] != 0)
            {
                matrix[i, j] *= -1;
            }
        }
    }
}

void ReplacementElementIndexEven(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j % 2 == 0 && i % 2 == 0)
            {
                matrix[i, j] *= matrix[i, j];
            }
        }
    }
}

string SearchNumber(int[,] matrix, int search)
{
    string total = String.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == search)
            {
                return total = $"rows: {i}, columns: {j}";
            }
            else
            {
                total = "There is no such number(((";
            }
        }
    }
    return total;
}

void Main()
{
    string enterM = "specify the number of array rows";
    string enterN = "specify the number of array columns";
    int M = GetValueNullNatural(enterM);
    int N = GetValueNullNatural(enterN);
    int[,] array = new int[M, N];
    
    FillTwoDimensionalArray(array);
    PrintTwoArray(array);

    int indicator = 4;
    string enterValue = "";
    int value = GetValueOptions(enterValue, indicator);
    while (value < indicator)
    {
        if (value == 1)
        {
            DateTime start = DateTime.Now;
            ReplacementElementOpposite(array);
            PrintTwoArray(array);
            double running = (DateTime.Now - start).TotalMilliseconds;
            System.Console.WriteLine($"Program_running_time: {running}");
        }
        if (value == 2)
        {
            DateTime start = DateTime.Now;
            ReplacementElementIndexEven(array);
            PrintTwoArray(array);
            double running = (DateTime.Now - start).TotalMilliseconds;
            System.Console.WriteLine($"Program_running_time: {running}");
        }
        if (value == 3)
        {
            string enterNumber = "What number to look for";
            int numberSearch = GetValueNullNatural(enterNumber);
            System.Console.WriteLine(SearchNumber(array, numberSearch));
        }
        value = GetValueOptions(enterValue, indicator);
    }
    System.Console.WriteLine("Thank you!");

}

Main();