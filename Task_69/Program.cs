/*
Напишите программу, которая на вход принимает два числа A и B, и возводит число A в целую степень B с помощью рекурсии.

A = 3; B = 5 -> 243 (3 в 5 степени)
A = 2; B = 3 -> 8
*/

int SumDigits(int num1, int num2)
{
    if (num2 == 0) return 1;
    return num1 * SumDigits(num1, num2 - 1);

    //return num2 == 0 ? 1 : num1 * SumDigits(num1, num2 -1);
    
}

Console.Write("Введите число A: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int numberOneAExtentNumberTwo = SumDigits(numberOne, numberTwo);
Console.WriteLine(numberOneAExtentNumberTwo);