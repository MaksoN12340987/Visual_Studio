// Array print method

// one-dimensional array
string PrintArray(string[] printarray)
{
    string print = string.Empty;
    for (int i = 0; i < printarray.Length; i++)
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