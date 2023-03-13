/*
Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

Например, задан массив:
1472
5923
8424
5267
Наименьший элемент - 1, на выходе получим следующий массив:
923
424
267
*/

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5} |");
            else Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}]");
//     }
// }

// Нахождение индексов минимального элемента
int[] MinIndexElementsMatrix(int[,] matrix)
{
    int min = matrix[0, 0];
    int[] arrayIndexMin = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                arrayIndexMin[0] = i;
                arrayIndexMin[1] = j;
            }
        }
    }
    return arrayIndexMin;
}

// Метод, с помощью которого удаляем строку и столбец с минимальным элементом
int[,] MatrixWithoutRowColMinElements(int[,] matrix, int[] minIndex)
{
    int[,] matrixWithoutElem = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0, n = 0;

    for (int i = 0; i < matrixWithoutElem.GetLength(0); i++)
    {
        if (m == minIndex[0]) m++; // пропуск строки

        for (int j = 0; j < matrixWithoutElem.GetLength(1); j++)
        {
            if (n == minIndex[1]) n++; // пропуск столбца
            matrixWithoutElem[i, j] = matrix[m, n];
            n++;
        }
        n = 0;
        m++;
    }
    return matrixWithoutElem;
}

int[,] array2D = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2D);
int[] arrayMinIndexElem = MinIndexElementsMatrix(array2D);
// PrintArray(arrayMinIndexElem);
Console.WriteLine();
int[,] array2DWithout = MatrixWithoutRowColMinElements(array2D, arrayMinIndexElem);
PrintMatrix(array2DWithout);