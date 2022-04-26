//              0   1  2  3    4     5   6   7  8    9  10   11  12 13
int[] array = { 9, 28, 1, 32, 1990, 16, 44, 39, 8, 334, 56, 777, 9, 7 };
int n = array.Length;
int find = 777;
int index = 0;
int indexFind = 0;

while (index < n)
{
    if (array[index] == find)
    {
        indexFind = index;
        // В таком случае бедет найден
        // последний элемент, равный
        // find
    }
    index++;

}

System.Console.WriteLine(indexFind);

// Иной способ:
// while (index < n)
// {
//     if (array[index] == find)
//     {
//         System.Console.WriteLine(index);(В таком случае 
//                                          отобразятся все элементы, 
//                                          равные find)
//         А если добавить:
//         break;(В этом случае отобразится самый первый 
//                найденый элемент, равный find)
//     }
//     index++;

// }
