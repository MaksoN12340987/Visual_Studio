﻿void main()
{
    int n = 5;
    int m = 4;

    int i = 0, j, k = 0, p = 1;

    while (i < n * m) /*Цикл по номеру витка*/
    {
        k++;
        for (j = k - 1; j < m - k + 1; j++)
        {
            Arr[k - 1, j] = p++;
            i++;
        }   /*Определение значений верхнего гор столбца*/

        for (j = k; j < n - k + 1; j++)
        {
            Arr[j, m - k] = p++;
            i++;
        }   /* --//-- По правому вертикальному столбцу*/

        for (j = m - k - 1; j >= k - 1; j--)
        {
            Arr[n - k, j] = p++;
            i++;
        }   /* --//-- по нижнему горизонтальному столбцу*/

        for (j = n - k - 1; j >= k; j--)
        {
            Arr[j, k - 1] = p++;
            i++;
        }   /* --//-- по левому вертикальному столбцу*/

    }
}