//              0   1  2  3    4     5   6   7    8    9  10  11 12 13
int[] array = { 9, 28, 1, 32, 1990, 16, 44, 39, 777, 334, 56, 1, 9, 7 };
int find = 777;
int index = 0;
int indexFind = 0;

while (index != 13)
{
    if (array[index] == find)
    {
        indexFind = index;
    }
    index++;
    
}

System.Console.WriteLine(indexFind);