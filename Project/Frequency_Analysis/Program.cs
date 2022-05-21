void FrequencyAnalysis(string[,] massive, int rowsMass, int columnsMass, string[] results)
{
    int length = massive.Length;
    for (int z = 0; z < length; z++)
    {
        int k = 0;
        for (int i = 0; i < rowsMass; i++)
        {
            for (int j = 0; j < columnsMass; j++)
            {
                double totalCount = 0;
                var temporarily = massive[i, j];
                double counter = 0;
                for (int r = 0; r < rowsMass; r++)
                {
                    for (int c = 0; c < columnsMass; c++)
                    {
                        if (temporarily == massive[r, c])
                        {
                            counter++;
                        }
                    }
                }
                totalCount = (counter / length) * 100;
                results[k] = $"Элемент: {temporarily} повторяется с вероятностью: {Math.Round(totalCount, 2)} %";
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
            print += $"{printarray[i]}";
            print += System.Environment.NewLine;
        }
    }
    return print;
}

void Main()
{
    // string enterM = "specify the number of array rows";
    // string enterN = "specify the number of array columns";
    // int rows = GetValueNullNatural(enterM);
    // int columns = GetValueNullNatural(enterN);

    string[,] arr = new string[,]{
    {"M", "a", "k", "s", "i", "m", "1", "1", "1"},
    {"M", "a", "k", "s", "i", "m", "2", "1", "2"}
    };

    // DateTime start = DateTime.Now;
    // int[,] array = new int[rows, columns];
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int col = arr.Length;
    string[] analysis = new string[col];

    // FillTwoDimensionalArray(array, rows, columns);
    // // Время заполнения массива
    // double running = (DateTime.Now - start).TotalMilliseconds;
    // System.Console.WriteLine($"Время заполнения массива Program_running_time: {running}");

    // start = DateTime.Now;
    FrequencyAnalysis(arr, rows, columns, analysis);
    // System.Console.WriteLine(PrintTwoArray(arr, rows, columns));
    // Время выполнения анализа
    // running = (DateTime.Now - start).TotalMilliseconds;
    // System.Console.WriteLine($"Время выполнения анализа Program_running_time: {running}");

    ArraySampleIdentical(analysis, col);
    System.Console.WriteLine(PrintArrayIf(analysis));
}

Main();