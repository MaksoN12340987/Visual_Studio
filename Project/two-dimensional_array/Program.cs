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

int FillTwoArray(int[,] collection)
{
    int line =0;
    int column=0;
    for (int i = 0; i < collection.Length; i++)
    {
        
    }
}