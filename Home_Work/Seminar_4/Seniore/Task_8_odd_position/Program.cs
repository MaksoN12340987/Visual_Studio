// 8. Найти сумму чисел одномерного массива стоящих на нечетной позиции

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
        full[i] = new System.Random().Next(0, 100);
    }
}

int SumOddPosition(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if ((i % 2) != 0)
        {
            sum = sum + mas[i];
        }
    }
    return sum;
}

void PrintArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        System.Console.Write($"{print[i]} ");
    }
}

int[] array = new int[GetValue(coll)];
FullArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(SumOddPosition(array));
