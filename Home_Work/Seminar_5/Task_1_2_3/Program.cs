// Задача 1
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Задача 2: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Задача 3: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

string enterMas = "Specify the number of elements in the array";
string enterValue = "";

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

int GetValueOptions(string text)
{
    string getValue = String.Empty;
    int value = 0;
    bool correct = false;
    System.Console.WriteLine("[1] - Показать количество чётных чисел");
    System.Console.WriteLine("[2] - Показать сумму элементов, стоящих на нечётных позициях");
    System.Console.WriteLine("[2] - Показать разницу между максимальным и минимальным элементов массива");
    System.Console.WriteLine("[4] - Завершить работу");
    while (!correct)
    {
        bool control = false;
        System.Console.Write($"Enter the {text}:");
        getValue = System.Console.ReadLine()!;
        control = int.TryParse(getValue, out value);
        if (control == true)
        {
            if (value != 0 && value < 5)
            {
                correct = true;
            }
        }
    }
    return value;
}

int coll = System.Convert.ToInt32(GetValueNullNatural(enterMas));
int value = System.Convert.ToInt32(GetValueOptions(enterValue));

void FillArray(int[] arrayFill, int arg1, int arg2)
{
    arg2++;
    for (int i = 0; i < arrayFill.Length; i++)
    {
        arrayFill[i] = new System.Random().Next(arg1, arg2);
    }
}

void FillArrayMaterial(double[] arrayFill, int arg1, int arg2)
{
    arg2++;
    for (int i = 0; i < arrayFill.Length; i++)
    {
        arrayFill[i] = new System.Random().Next(arg1, arg2);
    }
}

int PositiveNumbers(int[] masPositive)
{
    int seachPositive = 0;
    for (int i = 0; i < masPositive.Length; i++)
    {
        if (masPositive[i] % 2 == 0)
        {
            seachPositive++;
        }
    }
    return seachPositive;
}

int SumOddPosition(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + mas[i];
        }
    }
    return sum;
}

double MaxElement(double[] collection)
{
    double max = collection[0];
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > max)
        {
            max = collection[i];
        }
    }
    return max;
}

double MinElement(double[] collection)
{
    double min = collection[0];
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] < min)
        {
            min = collection[i];
        }
    }
    return min;
}

if (value < 4)
{
    if (value == 1)
    {
        int[] array = new int[coll];
        FillArray(array, 100, 999);
        PrintArray(array);
        System.Console.WriteLine();
        System.Console.WriteLine(PositiveNumbers(array));
    }
    if (value == 2)
    {
        int[] array = new int[coll];
        FillArray(array, 1, 999);
        PrintArray(array);
        System.Console.WriteLine();
        System.Console.WriteLine(SumOddPosition(array));
    }
    if (value == 3)
    {
        double[] array = new double[coll];
        FillArrayMaterial(array, -100, 100);
        PrintArrayMaterial(array);
        System.Console.WriteLine();
        System.Console.WriteLine((MaxElement(array))-(MinElement(array)));
    }
}
else
{
    System.Console.WriteLine("Thank you!");
}

void PrintArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        System.Console.Write($"{print[i]} ");
    }
}

void PrintArrayMaterial(double[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        System.Console.Write($"{print[i]} ");
    }
}