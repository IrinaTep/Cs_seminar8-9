/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
*/

bool DontRepeat(int num, int[] UnicNumbers)
{
    for(int i=0; i < UnicNumbers.GetLength(0); i++)
        if(num == UnicNumbers[i]) return true;
    return false;
}

// Метод для создания трехмерного массива
int[,,] CreateMatrixRndInt(int x, int y, int z, int min, int max, int[] UnicNumbers)
{
    int[,,] matrix = new int[x, y, z];
    Random rnd = new Random();

    int index=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             for (int k = 0; k < matrix.GetLength(2); k++)
             {
                int number;
                do {
                    number = rnd.Next(min, max +1);
                } while(DontRepeat(number, UnicNumbers));
                matrix[i, j, k] = number;
                UnicNumbers[index++] = number;
             }
        }
    }
    return matrix;
}

// Метод для выведения трехмерного массива
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k], 5}({i},{j},{k})");
            }
            Console.WriteLine("");
        }
    }
}

int[] UnicNumbers = new int[8];
int[,,] DMatrix = CreateMatrixRndInt (2, 2, 2, 10, 30, UnicNumbers);
PrintMatrix(DMatrix);