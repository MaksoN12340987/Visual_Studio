void FrequencyAnalysisString(string collection, int length, string[] results)
{
    int k = 0;
    for (int i = 0; i < length; i++)
    {
        var temporarily = collection[i];
        double counter = 0;
        for (int c = 0; c < length; c++)
        {
            if (temporarily == collection[c])
            {
                counter++;
            }
        }
        results[k] = $"Элемент: {(temporarily)} повторяется {counter, 3} раз";
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
    
    string text = "Класс Task представляет собой одну операцию, которая не возвращает значение и ";
    text += "обычно выполняется асинхронно. Taskобъекты являются одним из центральных компонентов ";
    text += "асинхронного шаблона на основе задач, впервые появившиеся в платформа .NET Framework 4. ";
    text += "Так как работа, выполняемая Task объектом, ";
    text += "обычно выполняется асинхронно в потоке пула потоков, ";
    text += "а не синхронно в основном потоке приложения, можно использовать Status свойство, ";
    text += "а также IsCanceledIsCompletedсвойства и IsFaulted свойства ";
    text += "для определения состояния задачи. ";
    text += "Чаще всего лямбда-выражение используется для указания работы, выполняемой задачей.";
    int col = text.Length;
    string[] analysis = new string[col];

    FrequencyAnalysisString(text, col, analysis);
    ArraySampleIdentical(analysis, col);
    System.Console.WriteLine(PrintArrayIf(analysis));
    double running = (DateTime.Now - start).TotalMilliseconds;
    System.Console.WriteLine($"Frequency analysis running time: {running}");
}

Main();