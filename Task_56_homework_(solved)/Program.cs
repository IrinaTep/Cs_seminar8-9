/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
// Метод для нахождения строки с наименьшей суммой элементов
int FindingTheLeastSum(int[,] matrix)
{
    int theLeastSum = 0;
    int theNumberOfTheRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int theSumOfTheRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            theSumOfTheRow += matrix[i, j];
        }

        if (i == 0) theLeastSum = theSumOfTheRow;

        if (theSumOfTheRow < theLeastSum)
        {
            theLeastSum = theSumOfTheRow;
            theNumberOfTheRow = i+1;
        }        
    }
    return theNumberOfTheRow;
}

Console.WriteLine("Дана матрица: ");
int[,] array2D = CreateMatrixRndInt(6, 4, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();
Console.Write($"Номер строки с наименьшей суммой элементов: {FindingTheLeastSum(array2D)}");
