void FillArray(int[] collectionFill)
{
    int lengntFill = collection.Length;
    int index = 0;
    while (indexFill < lengntFill)
    {
        collection[indexFill] = new Random().Next(1, 10);
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
