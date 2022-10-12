//Задача 47.
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] CreateMatrixRndDbl(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(rnd.Next(min, max + 1) * 0.1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < matrix.GetLength(1) - 1) Console.Write($"{Math.Round(matrix[i, j], 2),4} ");
            else Console.WriteLine($"{Math.Round(matrix[i, j], 2),4}");
        }
        Console.WriteLine("]");
    }
}

double[,] array2D = CreateMatrixRndDbl(3, 4, -100, 100);
PrintMatrix(array2D);
