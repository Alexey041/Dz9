/* Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();
Console.Write("Введите число ");
int a = int.Parse(Console.ReadLine()!);

Integers(a);

void Integers (int a)
{
    if (a == 0) return;
    Console.Write(a);
    Integers(a - 1);
}
