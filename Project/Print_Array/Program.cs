// Array print method

int[] array = new int[0];
int[,] array1 = new int[0,0];
int m = 0, n = 0;

// one-dimensional array
string PrintArray(int[] printarray, int Length)
{
    string print = string.Empty;
    for (int i = 0; i < Length; i++)
    {
        print += $"{printarray[i]} ";
        print += System.Environment.NewLine;
    }
    return print;
}

// two-dimensional array
string PrintTwoArray(int[,] massive, int rowsMass, int columnsMass)
{
    string print = string.Empty;
    for (int i = 0; i < rowsMass; i++)
    {
        for (int j = 0; j < columnsMass; j++)
        {
            print += $"{massive[i, j]} ";
        }
        print += System.Environment.NewLine;
    }
    return print;
}

// N-dimensional array


System.Console.WriteLine(PrintArray(array, m));
System.Console.WriteLine(PrintTwoArray(array1, m, n));