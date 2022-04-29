// 6. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N

string enter = String.Empty;

int GetValue(string text)
{
    string getValue = String.Empty;
    int value = 0;
    bool correct = false;
    while (!correct)
    {
        System.Console.Write("Enter the number: ");
        getValue = System.Console.ReadLine();
        correct = int.TryParse(getValue, out value);
    }
    return value;
}

void ArrayFull(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = (collection[i] + i) + 1;
    }
}

void PrintArray(int[] collectionPrint)
{
    for (int i = 0; i < collectionPrint.Length; i++)
    {
        System.Console.WriteLine(collectionPrint[i]);
    }
}

void SquareNumber(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = System.Convert.ToInt32(System.Math.Pow(mas[i], 3));
    }
}

int n = GetValue(enter);
int[] array = new int[n];
ArrayFull(array);
SquareNumber(array);
PrintArray(array);