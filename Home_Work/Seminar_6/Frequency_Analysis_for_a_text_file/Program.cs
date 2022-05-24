void FrequencyAnalysisString(string collection, int length, string[] results)
{
    int k = 0;
    for (int i = 0; i < length; i++)
    {
        double totalCount = 0;
        var temporarily = collection[i];
        double counter = 0;
        for (int c = 0; c < length; c++)
        {
            if (temporarily == collection[c])
            {
                counter++;
            }
        }
        if (true)
        {
            
        }
        totalCount = (counter / length) * 100;
        results[k] = $"Элемент: {(temporarily)} повторяется с вероятностью: {Math.Round(totalCount, 2)} %";
        k++;
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
    DateTime start = DateTime.Now;
    
    string text = @"A:\ФАЙЛЫ\Visual_Studio\C#\Project\Frequency_Analysis\text.txt";
    int col = text.Length;
    string[] analysis = new string[col];

    FrequencyAnalysisString(text, col, analysis);
    ArraySampleIdentical(analysis, col);
    System.Console.WriteLine(PrintArrayIf(analysis));
    double running = (DateTime.Now - start).TotalMilliseconds;
    System.Console.WriteLine($"Frequency analysis running time: {running}");
}

Main();