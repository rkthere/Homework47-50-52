//Задача 52.
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4


int[,] CreateMatrixRndIntWithAvg(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            matrix[i, j] = rnd.Next(min, max + 1);
            avarage = (avarage + matrix[i, j]);

        }
        avarage = avarage / rows;
        Console.WriteLine($"Среднее арифметическое столбца {j+1} -> {Math.Round(avarage, 2)}; ");
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}
int[,] array2D = CreateMatrixRndIntWithAvg(3, 4, 0, 10);
PrintMatrix(array2D);