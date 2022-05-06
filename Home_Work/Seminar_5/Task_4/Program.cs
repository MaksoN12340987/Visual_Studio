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
    int index = 0;
    int lenght = collection.Length;
    int[] mas = new int[lenght]; ;
    while (index < lenght)
    {
        collection[index] = (collection[index] + index) + 1;
        index++;
    }
}

int[] array = new int[GetValueNullNatural(enterMas)];
FillArray(array);
