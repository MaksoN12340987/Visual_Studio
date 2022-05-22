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
    string[,] arr = new string[,]{
    {"M", "a", "k", "s", "i", "m", "1", "1", "1"},
    {"M", "a", "k", "s", "i", "m", "2", "1", "2"}
    };
    System.Console.WriteLine();
    string text = "Частотный анализ – это один из методов криптоанализа, основывающийся на предположении о ";
    text += "существовании нетривиального статистического распределения отдельных символов и их ";
    text += "последовательностей как в открытом тексте, так и шифрованном тексте, которое с точностью до замены ";
    text += "символов будет сохраняться в процессе шифрования и дешифрования. ";
    text += "Частотный анализ может выглядеть так";
    System.Console.WriteLine(text);
    System.Console.WriteLine();
    int rows = text.Length;
    int col = text.Length;
    string[] analysis = new string[col];

    // FrequencyAnalysis(arr, rows, columns, analysis);
    // // Время выполнения анализа
    // double running = (DateTime.Now - start).TotalMilliseconds;
    // System.Console.WriteLine($"Время выполнения анализа Program_running_time: {running}");

    // ArraySampleIdentical(analysis, col);
    // System.Console.WriteLine(PrintArrayIf(analysis));
    FrequencyAnalysisString(text, col, analysis);
    ArraySampleIdentical(analysis, col);
    System.Console.WriteLine(PrintArrayIf(analysis));
}

Main();