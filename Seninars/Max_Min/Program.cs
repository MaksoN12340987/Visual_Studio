string MaxMinElement(int[] collection)
{
    int max = collection[0];
    int min = collection[0];
    string total = "";
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] < min)
        {
            min = collection[i];
        }
        else
        {
            if (collection[i] > max)
            {
                max = collection[i];
            }
        }
    }
    total = $"Maximum element: {max}, Minimal element: {min}";
    return total;
}

int[] array = { 1, 6, 6, 9, 7, -3 };
System.Console.WriteLine(MaxMinElement(array));