// 1. Задать массив из 8 элементов и вывести их на экран

int coll = 8;
int[] array = new int[coll];

void PrintArray(int[] collectionPrint)
{
    for (int i = 0; i < collectionPrint.Length; i++)
    {
        System.Console.WriteLine(collectionPrint[i]);
    }
}


// 2. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FullArray(int[] collectionFull)
{
    for (int i = 0; i < collectionFull.Length; i++)
    {
        collectionFull[i] = new Random().Next(0, 2);
    }
}

FullArray(array);
PrintArray(array);