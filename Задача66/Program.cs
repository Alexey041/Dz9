/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
элементов в промежутке от M до N. Рекурсивно
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();
Console.Write("Введите число M ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(Sum(m) - 1);


int Sum (int m)
{
    if (m <= n)
    {
        return m + Sum(m + 1);
    }
    else
    {
        return 1;
    }
}
