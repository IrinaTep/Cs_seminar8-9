﻿/*
Задайте значения M и N.
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/

Console.WriteLine("введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

GapNaturalNumbers(number1, number2);

void GapNaturalNumbers(int num1, int num2)
{
    Console.Write($"{num1} ");
    if(num1 == num2) return;
    if (num1 > num2)
    {
        GapNaturalNumbers(num1 -1, num2);
    }
    else
    {
        GapNaturalNumbers(num1 + 1, num2);
    }
}