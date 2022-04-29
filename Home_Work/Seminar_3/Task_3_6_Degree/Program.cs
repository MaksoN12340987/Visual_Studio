// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.

// 6. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N

string enterNumber = String.Empty;
string enterDegree = String.Empty;

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

int GetValueDegree(string text)
{
    string getValue = String.Empty;
    int value = 0;
    bool correct = false;
    while (!correct)
    {
        System.Console.Write("Enter degree: ");
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

void PrintArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        System.Console.Write($"{print[i]}, ");
    }
}

void SquareNumber(int[] mas, int degreeMasNumber)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = System.Convert.ToInt32(System.Math.Pow(mas[i], degreeMasNumber));
    }
}

int n = GetValue(enterNumber);
int degree = GetValueDegree(enterDegree);
int[] array = new int[n];
ArrayFull(array);
SquareNumber(array, degree);
PrintArray(array);