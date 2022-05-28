// Составить частотный словарь элементов двумерного массива

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

void FillTwoDimensionalArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new System.Random().Next(0, 100);
        }
    }
}

string PrintTwoArray(int[,] array, int rows, int columns)
{
    string print = string.Empty;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            print += $"{array[i, j], 2} ";
        }
        print += System.Environment.NewLine;
    }
    return print;
}

void FrequencyAnalysis(int[,] array, int rows, int columns, string[] results)
{
    int length = array.Length;
    for (int z = 0; z < length; z++)
    {
        int k = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int temporarily = array[i, j];
                double counter = 0;
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        if (temporarily == array[r, c])
                        {
                            counter++;
                        }
                    }
                }
                results[k] = $"Element: {temporarily, 2} frequency: {counter, 3} times";
                k++;
            }
        }
    }
}

void ArraySampleIdentical(string[] collection, int length)
{
    string[] temporarily = new string[length];
    for (int i = 0; i < length; i++)
    {
        temporarily[i] = collection[i];
        int counter = 0;
        for (int r = 0; r < length; r++)
        {
            if (temporarily[r] == collection[i])
            {
                counter++;
            }
            if (counter > 1)
            {
                collection[i] = String.Empty;
            }
        }
    }
}

string PrintArrayIf(string[] printarray)
{
    string print = string.Empty;
    for (int i = 0; i < printarray.Length; i++)
    {
        if (printarray[i] != String.Empty)
        {
            print += $"{printarray[i], 3}";
            print += System.Environment.NewLine;
        }
    }
    return print;
}

void Main()
{
    string enterM = "specify the number of array rows";
    string enterN = "specify the number of array columns";
    int rows = GetValueNullNatural(enterM);
    int columns = GetValueNullNatural(enterN);

    DateTime start = DateTime.Now;
    int[,] array = new int[rows, columns];
    int col = array.Length;
    string[] analysis = new string[col];
    FillTwoDimensionalArray(array, rows, columns);

    FrequencyAnalysis(array, rows, columns, analysis);
    System.Console.WriteLine(PrintTwoArray(array, rows, columns));
    double running = (DateTime.Now - start).TotalMilliseconds;
    System.Console.WriteLine($"Frequency analysis running time: {running}");

    ArraySampleIdentical(analysis, col);
    System.Console.WriteLine(PrintArrayIf(analysis));
}

Main();