System.Console.Write("Enter n: ");
int n = Convert.ToInt32(System.Console.ReadLine()!);
System.Console.WriteLine();
int[] array = new int[n]!;

void ArrayFull(int[] collection)
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

void EvenNumbersArray(int[] numbersPrint)
{
    int lengntEven = numbersPrint.Length;
    int indexEven = 0;
    while (indexEven < lengntEven)
    {
        if (numbersPrint[indexEven] % 2 == 0)
        {
            System.Console.WriteLine(numbersPrint[indexEven]);
            indexEven++;
        }
        else
        {
            indexEven++;
        }
    }
}

ArrayFull(array);
EvenNumbersArray(array);