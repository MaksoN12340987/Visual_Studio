// Найти сумму чисел от 1 до А

string enterMas = "Specify the number of elements in the array";

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

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = (collection[i] + i) + 1;
    }
}

int SumElements(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        sum += mas[i];
    }
    return sum;
}

int[] array = new int[GetValueNullNatural(enterMas)];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(SumElements(array));

void PrintArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        System.Console.Write($"{print[i]} ");
    }
}