// Работа с двумерными и многомерными сассивами
// Двумерный массив, в математике, называется матрицей

//  не забыть запятые       строк столбцов
//  int[,] matrix = new int[rows, columns];

int[,] matrix = new int[3, 4];

void PrintTwoArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            System.Console.Write($"{massive[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

PrintTwoArray(matrix);