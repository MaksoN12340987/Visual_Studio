// 7. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

string coll = "Specify the number of elements in the array";
string enterStart = "Search segment start";
string enterEnd = "End of search segment";

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
        full[i] = new System.Random().Next(1, 1000);
    }
}

int CollNumbers(int[] collPositive, int arg1, int arg2)
{
    int seachPositive = 0;
    for (int i = 0; i < collPositive.Length; i++)
    {
        if (collPositive[i] > arg1 & collPositive[i] < arg2)
        {
            seachPositive++;
        }
    }
    return seachPositive;
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

// PrintArray(array);

int start = GetValue(enterStart);
int end = GetValue(enterEnd);

int collNumbersSeach = CollNumbers(array, start, end);
System.Console.WriteLine(collNumbersSeach);