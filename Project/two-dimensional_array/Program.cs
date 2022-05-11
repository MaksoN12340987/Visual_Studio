string enterN = "specify the number of array rows";
string enterM = "specify the number of array columns";

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

void CreateTwoDimensionalArray(int[,] massive)
{
     = 0;
    int line = 0;
    int constant = 1;
    for (int coll = 0; coll < column; coll++)
    {
        for (int i = 0; i < column; i++)
        {
            collection[i, line] += constant;
        }
    }
}

void PrintTwoArray(int[,] colleclion)
{
    int indexColumn = 0;

}

CreateTwoDimensionalArray(GetValueNullNatural(enterN), GetValueNullNatural(enterM));

int[,] array = 