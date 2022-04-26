// Задать массив из 8 элементов и вывести их на экран

int coll = 8;
int[] array = new int[coll];

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

PrintArray(array);