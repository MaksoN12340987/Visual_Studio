int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
array[0] = 1;

int ArrayFull(int[] collection)
{
    int index = 1;
    while (index < n)
    {
        array[index]++;
        index++;
    }
}

int[] Array = new int[n];
Array = ArrayFull(array);

System.Console.WriteLine(Array);

// int ParityNumber(int[] collection)
// {
//     int index = 0;
//     int lenght = array.Length;
//     int[] parityNumbers = {0};
//     while (index < lenght)
//     {

//     }
// }

