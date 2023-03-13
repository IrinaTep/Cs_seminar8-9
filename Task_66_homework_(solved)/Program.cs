/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

SumNaturalNumbers(number1, number2);

void SumNaturalNumbers(int num1, int num2, int sum=0)
{
    Console.Write($"{num1} ");
    sum += num1;    
    if(num1 == num2) 
    {    
        Console.WriteLine("");
        Console.WriteLine($"Сумма чисел: {sum} ");
        return;
    }
    if(num1 > num2)
    {
        SumNaturalNumbers(num1 - 1, num2, sum);
    }
    else
    {
        SumNaturalNumbers(num1 + 1, num2, sum);
    }

}