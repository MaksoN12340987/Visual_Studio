void FillArray(int[] collectionFill)
{
    int lengntFill = collectionFill.Length;
    int indexFill = 0;
    while (indexFill < lengntFill)
    {
        collectionFill[indexFill] = new Random().Next(1, 10);
        indexFill++;
    }
}

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

int[] array = new int[10];
FillArray(array);
PrintArray(array);
