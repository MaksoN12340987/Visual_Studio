﻿// Составить частотный словарь элементов двумерного массива

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

void PrintTwoArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            System.Console.Write($"{massive[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FrequencyAnalysis(int[,] massive, string[] results)
{
    int rows = massive.GetLength(0);
    int columns = massive.GetLength(1);
    int length = massive.Length;
    for (int z = 0; z < length; z++)
    {
        int k = 0;
        for (int i = 0; i < rows; i++)
        {
            
            for (int j = 0; j < columns; j++)
            {
                double totalCount = 0;
                int temporarily = massive[i,j];
                double counter = 0;
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        if (temporarily == massive[r,c])
                        {
                            counter++;
                        }
                    }
                }
                totalCount = (counter / length) * 100;
                results[k] =$"Элемент: {temporarily} встречается с частотой: {Math.Round(totalCount, 2)} %";
                k++;
            }
        }

    }
}

void PrintArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        System.Console.Write($"{print[i]}, ");
    }
}

void PrintArrayIf(string[] massEnter)
{
    int length = massEnter.Length;
    for (int i = 0; i < length; i++)
    {
        System.Console.WriteLine(massEnter[i]);
        string temp = massEnter[i];
        for (int j = 0; j < length; j++)
        {
            System.Console.WriteLine($"         ------------{massEnter[j]}");
            System.Console.WriteLine($"         {temp}");
            if (temp == massEnter[j])
            {
                
                massEnter[i] = string.Empty;
            }
            
        }
    }
}

void FillTwoDimensionalArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new System.Random().Next(0, 10);
        }
    }
}

void Main()
{
    string enterM = "specify the number of array rows";
    string enterN = "specify the number of array columns";
    int[,] array = new int[GetValueNullNatural(enterM), GetValueNullNatural(enterN)];
    string[] analysis = new string[array.Length];
    FillTwoDimensionalArray(array);
    FrequencyAnalysis(array, analysis);
    PrintTwoArray(array);
    PrintArrayIf(analysis);
}

Main();