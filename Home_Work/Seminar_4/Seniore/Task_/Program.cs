// 3. Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

int coll = 12;
int[] array = new int[coll];
int[] arrayNegative = { -1, -2, 3, -4 };

void FullArray(int[] full)
{
    for (int i = 0; i < full.Length; i++)
    {
        full[i] = new System.Random().Next(0, 10);
    }
}

void PrintArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        System.Console.Write($"{print[i]}, ");
    }
}

int PositiveNumbers(int[] masPositive)
{
    int sumPositive = 0;
    for (int i = 0; i < masPositive.Length; i++)
    {
        if (masPositive[i] > 0)
        {
            sumPositive = sumPositive + masPositive[i];
        }
    }
    return sumPositive;
}

int NegativeNumbers(int[] masNegative)
{
    int sumNegative = 0;
    for (int i = 0; i < masNegative.Length; i++)
    {
        if (masNegative[i] < 0)
        {
            sumNegative = sumNegative + masNegative[i];
        }
    }
    return sumNegative;
}

string PrintNegativeNumbers(int answer)
{
    string text = String.Empty;
    if (answer == 0)
    {
        text = "No negative numbers";
    }
    return text;
}

FullArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(PositiveNumbers(array));
System.Console.WriteLine(PrintNegativeNumbers(NegativeNumbers(array)));
if (PrintNegativeNumbers(NegativeNumbers(array)) == String.Empty)
{
    System.Console.WriteLine(NegativeNumbers(array));
}