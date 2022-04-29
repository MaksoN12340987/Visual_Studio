// 6. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

string coll = "Specify the number of elements in the array";

int GetValue(string text)
{
    string getValue = String.Empty;
    int value = 0;
    bool correct = false;
    while (!correct)
    {
        System.Console.Write($"{text}: ");
        getValue = System.Console.ReadLine()!;
        correct = int.TryParse(getValue, out value);
    }
    return value;
}

void FullArray(int[] full)
{
    for (int i = 0; i < full.Length; i++)
    {
        full[i] = new System.Random().Next(100, 1000);
    }
}

int PositiveNumbers(int[] masPositive)
{
    int seachPositive = 0;
    for (int i = 0; i < masPositive.Length; i++)
    {
        if (masPositive[i] > 0)
        {
            seachPositive++;
        }
    }
    return seachPositive;
}

int NegativeNumbers(int[] masNegative)
{
    int seachNegative = 0;
    for (int i = 0; i < masNegative.Length; i++)
    {
        if (masNegative[i] < 0)
        {
            seachNegative++;
        }
    }
    return seachNegative;
}

string PrintAnswerPositive(int total)
{
    string text = String.Empty;
    if (total != 0)
    {
        text = $"Positive numbers: {total}";
    }
    else
    {
        text = "No positive numbers";
    }
    return text;
}

string PrintAnswerNegative(int total)
{
    string text = String.Empty;
    if (total != 0)
    {
        text = $"Negative numbers: {total}";
    }
    else
    {
        text = "No negative numbers";
    }
    return text;
}

int[] array = new int[GetValue(coll)];
FullArray(array);

// void PrintArray(int[] print)
// {
//     for (int i = 0; i < print.Length; i++)
//     {
//         System.Console.Write($"{print[i]}, ");
//     }
// }

// array[2] = -241;
// PrintArray(array);

int collPositive = PositiveNumbers(array);
int collNegative = NegativeNumbers(array);

System.Console.WriteLine(PrintAnswerPositive(collPositive));
System.Console.WriteLine(PrintAnswerNegative(collNegative));