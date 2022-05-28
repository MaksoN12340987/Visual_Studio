// Сформировать трехмерный массив не повторяющимися двузначными числами 
// показать его построчно на экран выводя индексы соответствующего элемента


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

string PrintTwoArraySquare(int[,,] printArray, int arg1, int arg2, int arg3, int length)
{
    string print = string.Empty;
    for (int x = 0; x < arg1; x++)
    {
        for (int y = 0; y < arg2; y++)
        {
            for (int z = 0; z < arg3; z++)
            {
                print += $"{printArray[x, y, z]} ({x}, {y}, {z}) ";
                
            }
            print += System.Environment.NewLine;
        }
    }
    return print;
}

void FillTwoDimensionalArraySquare(int[,,] mass, int arg1, int arg2, int arg3, int length)
{
    int value = 10;
    for (int x = 0; x < arg1; x++)
    {
        for (int y = 0; y < arg2; y++)
        {
            for (int z = 0; z < arg3; z++)
            {
                mass[x, y, z] = value;
                value++;
            }
        }
    }
}

void Main()
{
    string enterN = "how many elements in X";
    string enterM = "how many elements in Y";
    string enterZ = "how many elements in Z";
    int M = GetValueNullNatural(enterM);
    int N = GetValueNullNatural(enterN);
    int Z = GetValueNullNatural(enterZ);
    int[,,] array = new int[M, N, Z];
    int col = array.Length;
    FillTwoDimensionalArraySquare(array, M, N, Z, col);
    System.Console.WriteLine(PrintTwoArraySquare(array, M, N, Z, col));
}

Main();