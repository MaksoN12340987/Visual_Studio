int[] array = {2, 3, 7};

int MaxElement(int[] collection)
{
    int index = 0;
    int max = array[0];
    int lenght = array.Length;
    while (index < lenght)
    {
    if (array[index]>max)
    {
        max = array[index];
    }
    index++;
    }
    return max;
}

int MAX = MaxElement(array);
System.Console.Write("Maximum element of the array = ");
System.Console.WriteLine(MAX);