/*
Задайте двумерный массив.
Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

// Метод для создания двухмерного массива
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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

// Метод, меняющий местами строки и столбцы
// int[,] ReplaceRowsColumns(int[,] matrix)
// {
//     int[,] tmpArray = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             tmpArray[j, i] = matrix[i, j];
//         }
//     }
//     return tmpArray;
// }

// Метод, меняющий местами строки и столбцы (2 способ)
void ChangeRowsOnColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temporary = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temporary;
        }
    }
}

// Метод для выведения двухмерного массива
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

int[,] matrix = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
if (matrix.GetLength(0) == matrix.GetLength(1))
{
    // int[,] newMatrix = ChangeRowsOnColumns(matrix);
    // PrintMatrix(newMatrix);
    ChangeRowsOnColumns(matrix);
    PrintMatrix(matrix);
}
else Console.WriteLine("Число строк и столбцов не совпадает");