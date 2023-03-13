/*
Задайте значение N.
Напишите прграмму, которая выведет все натуральные числа в промежутке от 1 до N.

N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

Console.WriteLine("Введите натуральное числ: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if(num == 0) return;
    // Console.Write($"{num} ");
    NaturalNumbers(num -1);
    Console.Write($"{num} "); // выводится в нужном порядке, потому что сохранение выполнется в стек
}