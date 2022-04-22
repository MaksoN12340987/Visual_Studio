System.Console.Write("Enter n: ");
int n = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine();
int index = (n * 2) + 1;
int[] array = new int[index];
array[0] = -n;

void ArrayFull(int[] collection)
{
    int indexFill = 1;
    int lengntFill = collection.Length;
    int save = collection[0];
    while (indexFill < lengntFill)
    {
        if (save < 0)
        {
            int indexSave = collection[(indexFill--)];
            collection[indexFill] = collection[indexSave] + 1;
            indexFill++;
            save++;
        }
        if (save > 0)
        {
            
            collection[indexFill] = collection[indexFill] + save;
            indexFill++;
            save++;
        }
        else
        {
            indexFill++;
            save++;
        }
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

ArrayFull(array);
PrintArray(array);