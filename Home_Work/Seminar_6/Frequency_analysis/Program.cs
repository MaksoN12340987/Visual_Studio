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

void FrequencyAnalysis(int[,] massive, string[] results)
{
    int rows = massive.GetLength(0);
    int columns = massive.GetLength(1);
    int k = 0;
    for (int z = 0; z < massive.Length; z++)
    {
        for (int i = 0; i < rows; i++)
        {
            
            for (int j = 0; j < columns; j++)
            {
                int totalCount = 0;
                int temporarily = massive[i,j];
                int counter = 0;
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        if (temporarily == massive[r,c])
                        {
                            counter++;
                        }
                    }
                }
                totalCount = (counter / massive.Length) * 100;
                results[k] =$"Элемент: {temporarily} встречается с частотой: {totalCount}";
                k++;
            }
        }

    }
}

void PrintArray(string[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        System.Console.Write($"{print[i]}, ");
    }
}

void Main()
{
    // string enterM = "specify the number of array rows";
    // string enterN = "specify the number of array columns";
    // int M = GetValueNullNatural(enterM);
    // int N = GetValueNullNatural(enterN);
    // int[,] array = new int[GetValueNullNatural(enterM), GetValueNullNatural(enterN)];
    int[,] array = new int[,]{
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9},
    };
    string[] analysis = new string[array.Length];
    FrequencyAnalysis(array, analysis);
    PrintTwoArray(array);
    PrintArray(analysis);

}

Main();