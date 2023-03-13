/*
Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

// Метод для создания двухмерного массива
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
// Метод для выведения двухмерного массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}
// Метод для нахождения произведений двух матриц
int[,] TwoMatrixProduction(int[,] matrix1, int[,] matrix2)
{
    int[,] twoMatrixProduction = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < twoMatrixProduction.GetLength(0); i++)
    {
        for (int j = 0; j < twoMatrixProduction.GetLength(1); j++)
        {
            for (int k = 0; k < twoMatrixProduction.GetLength(0); k++)
            {
                twoMatrixProduction[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return twoMatrixProduction;
}

Console.WriteLine("Даны две матрицы: ");
int[,] array2D1 = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(array2D1);
Console.WriteLine();
int[,] array2D2 = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(array2D2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица будет: ");
if ((array2D1.GetLength(0) == array2D2.GetLength(0)) && (array2D1.GetLength(1) == array2D2.GetLength(1)))
{
    PrintMatrix(TwoMatrixProduction(array2D1, array2D2));
}
else Console.WriteLine("Произведение данных двух матриц невозможно");