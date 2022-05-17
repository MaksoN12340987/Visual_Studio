// Написать программу преобразования десятичного числа в двоичное



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

int ConvertBinarySystem(int number)
{
    int total = 0;
    if (number < 10)
    {
        total = number % 2;
    }
    else
    {
        for (int i = 0; i < number; i++)
        {
            total = (number % 2) *10;
        }
    }
    return total;
}

void Main()
{
    string enter = "specify the number of array rows";
    int value = GetValueNullNatural(enter);
    ConvertBinarySystem(value);
}

Main();