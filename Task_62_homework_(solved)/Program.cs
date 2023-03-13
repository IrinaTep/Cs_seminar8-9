/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

// Метод для создания двухмерного массива
int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int amountOfElem = rows * columns;
    int i = 1;
    int p = 0;
    int par = 0;
    while(i <= amountOfElem)
    {
        // Вправо
        for(int ind=par; ind < matrix.GetLength(1) - par; ind++)
        {
            //Console.WriteLine($"Вправо {par} {ind}");
            matrix[par, ind] = i;
            i++;
        }
        p = matrix.GetLength(1) - par - 1;
        // Вниз
        for(int ind=par+1; ind < matrix.GetLength(0) - par; ind++)
        {
            //Console.WriteLine($"Вниз {ind} {p}");                        
            matrix[ind, p] = i;
            i++;
        }        
        p = matrix.GetLength(0) - par - 1;
        // Влево
        for(int ind=matrix.GetLength(1) - par - 2; ind >= par ; ind--)
        {
            //Console.WriteLine($"Влево {p} {ind}");              
            matrix[p, ind] = i;
            i++;
        }       
        p = matrix.GetLength(1) - par -1;
        // Вверх
        for(int ind=matrix.GetLength(0) - par - 2; ind > par ; ind--)
        {
            //Console.WriteLine($"Вверх {ind} {par}");                          
            matrix[ind, par] = i;
            i++;
        }
        //Console.WriteLine($"par={par} ************");
        //Console.WriteLine($"i={i} ************");        
        par++;
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5} |");
            else Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

PrintMatrix(CreateMatrixRndInt(4,4));
Console.WriteLine("");
PrintMatrix(CreateMatrixRndInt(10,10));