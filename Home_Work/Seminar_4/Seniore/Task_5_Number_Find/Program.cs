// 5. Определить, присутствует ли в заданном массиве, некоторое число

string coll = "Specify the number of elements in the array(0, 2)";
string number = "What number to find?";

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
        full[i] = new System.Random().Next(0, 3);
    }
}

int NumberFind(int[] findNumbers, int numberSeach)
{
    int total = 0;
    for (int i = 0; i < findNumbers.Length; i++)
    {
        if (findNumbers[i] == numberSeach)
        {
            total = 1;
        }
    }
    return total;
}

string PrintAnswer(int answer)
{
    string text = String.Empty;
    if (answer == 1)
    {
        text = "Yes";
    }
    else
    {
        text = "No";
    }
    return text;
}

// void PrintArray(int[] print)
// {
//     for (int i = 0; i < print.Length; i++)
//     {
//         System.Console.Write($"{print[i]}, ");
//     }
// }

int[] array = new int[GetValue(coll)];
FullArray(array);
// PrintArray(array);

int find = GetValue(number);
System.Console.WriteLine(PrintAnswer(NumberFind(array, find)));