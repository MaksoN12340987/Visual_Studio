// 4. Написать программу замену элементов массива на противоположные

string coll = String.Empty;

int GetValue(string text)
{
    string getValue = String.Empty;
    int value = 0;
    bool correct = false;
    while (!correct)
    {
        System.Console.Write("Enter the number: ");
        getValue = System.Console.ReadLine()!;
        correct = int.TryParse(getValue, out value);
    }
    return value;
}

void FullArray(int[] full)
{
    for (int i = 0; i < full.Length; i++)
    {
        full[i] = new System.Random().Next(-10, 10);
    }
}

void PrintArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        System.Console.Write($"{print[i]}, ");
    }
}

void ArrayReSing(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > 0)
        {
            collection[i] = -collection[i];
        }
        else
        {
            collection[i] = System.Math.Abs(collection[i]);
        }
    }
}

int[] array = new int[GetValue(coll)];
FullArray(array);
PrintArray(array);
System.Console.WriteLine();
ArrayReSing(array);
PrintArray(array);