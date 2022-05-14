// В двумерном массиве n×k заменить четные элементы на противоположные

// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

// В двумерном массиве показать позиции числа, заданного пользователем 
// или указать, что такого элемента нет

// В матрице чисел найти сумму элементов главной диагонали

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

int GetValueOptions(string text)
{
    string getValue = String.Empty;
    int value = 0;
    bool correct = false;
    System.Console.WriteLine("[1] - Заменить четные элементы на противоположные");
    System.Console.WriteLine("[2] - Заменить элементы, у которых оба индекса чётные на их квадраты");
    System.Console.WriteLine("[3] - Вывести позицию заданного числа");
    System.Console.WriteLine("[4] - Сумма элементов главной диагонали");

    System.Console.WriteLine("[5] - Завершить работу");
    while (!correct)
    {
        bool control = false;
        System.Console.Write($"Enter the {text}:");
        getValue = System.Console.ReadLine()!;
        control = int.TryParse(getValue, out value);
        if (control == true)
        {
            if (value != 0 && value < 6) // Сколько позиций выбора + 1
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
            mass[j, i] = new System.Random().Next(0, 10);
        }
    }
}

void ReplacementElementOpposite(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[j, i] % 2 == 0)
            {
                matrix[j, i] *= -1;
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
                matrix[j, i] *= matrix[j, i];
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
            if (matrix[j, i] == search)
            {
                return total = $"rows: {j}, columns: {i}";
            }
            else
            {
                total = "There is no such number(((";
            }
        }
    }
    return total;
}

int SumElementsMainDiagonal(int[,] mass)
{
    int i = mass.GetLength(0);// (arg1 - 1)(arg2 - 1) int arg1, int arg2
    int j = 0;
    int sumElements = 0;
    while(j <= mass.GetLength(1))
    {
        sumElements = sumElements + mass[i,j];
        j++;
        i--;
    }
    return sumElements;
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
    int indicator = 5; // Сколько позиций выбора. Не забудь изменить метод
    string enterM = "specify the number of array rows";
    string enterN = "specify the number of array columns";
    string enterValue = "";
    int M = GetValueNullNatural(enterM);
    int N = GetValueNullNatural(enterN);
    int[,] array = new int[M,N];
    FillTwoDimensionalArray(array);
    PrintTwoArray(array);
    int value = System.Convert.ToInt32(GetValueOptions(enterValue));
    while (value != indicator)
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
        if (value == 4)
        {
            DateTime start = DateTime.Now;
            System.Console.WriteLine(SumElementsMainDiagonal(array));
            double running = (DateTime.Now - start).TotalMilliseconds;
            System.Console.WriteLine($"Program_running_time: {running}");
        }
        value = System.Convert.ToInt32(GetValueOptions(enterValue));
    }
    System.Console.WriteLine("Thank you!");
}

Main();