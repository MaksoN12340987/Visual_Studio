int[] array = { 563, 98 };

int MinElement(int[] collection)
{
    int index = 0;
    int min = array[0];
    int lenght = array.Length;
    while (index < lenght)
    {
        if (array[index] < min)
        {
            min = array[index];
        }
        index++;
    }
    return min;
}

int MaxElement(int[] collection)
{
    int index = 0;
    int max = array[0];
    int lenght = array.Length;
    while (index < lenght)
    {
        if (array[index] > max)
        {
            max = array[index];
        }
        index++;
    }
    return max;
}

int MAX = MaxElement(array);
int MIN = MinElement(array);

System.Console.Write("Maximum element of the array = ");
System.Console.WriteLine(MAX);
System.Console.Write("Minimal element of array = ");
System.Console.WriteLine(MIN);