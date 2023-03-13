/*
Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Набор данных                                      Частотный массив
{1, 9, 9, 0, 2, 8, 0, 9}                          0 встречается 2 раза
                                                  1 встречается 1 раз
                                                  2 встречается 1 раз
                                                  8 встречается 1 раз
                                                  9 встречается 3 раза

1, 2, 3                                           1 встречается 1 раз       
4, 6, 1                                           2 встречается 2 раза
2, 1, 6                                           3 встречается 1 раз  
                                                  4 встречается 1 раз 
                                                  6 встречается 2 раза   
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
             matrix[i, j] = rnd.Next(min, max +1);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5} |");
            else Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

// Метод, переделывающий двумерный массив в одномерный
int[] MatrixToArray(int[,] matrix)
{
    int[] result = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[count++] = matrix[i, j];       // То же самое, как если бы написали: result[count++] = matrix[i, j];
        }                                         // count++;
    }
    return result;
}

string PrintArray(int[] arr)
{
    string str = String.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        str += $"{arr[i]}";
    }
    return str;
}

void GetSameCountNumbers(int[] arr)
{
    int tmp = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i ++)
    {
        if (tmp == arr[i]) count++;
        else
        {
            Console.WriteLine($"{tmp} - {count}");
            tmp = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{tmp} - {count}");
}

int[,] matrixNumbers = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matrixNumbers);

int[] array = MatrixToArray(matrixNumbers);
Array.Sort(array);
Console.WriteLine(PrintArray(array));

GetSameCountNumbers(array);