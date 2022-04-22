System.Console.Write("Enter n: ");
int n = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine();
int[] array = new int[n];

void ArrayFull(int[] collection)
{
    int index = 0;
    int lenght = n;
    int[] mas = new int[lenght];;
    while (index < n)
    {
        collection[index] = (collection[index] + index) + 1;
        index++;
    }
}

// Добавил метод PrintArray только для проверки элементов массива
void PrintArray(int[] collectionPrint)
{
    int lengntPrint = collectionPrint.Length;
    int indexFill = 0;
    while (indexFill < lengntPrint)
    {
        System.Console.WriteLine(collectionPrint[indexFill]);
        indexFill++;
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
// PrintArray(array);
EvenNumbersArray(array);