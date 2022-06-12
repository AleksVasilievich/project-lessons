// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter a namber M -> ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter a namber N -> ");
int n = int.Parse(Console.ReadLine());

SumMN(m, n);

int SumMN(int m, int n)
{
    if(m == n) return m;
    if (m > n) return m + SumMN(m - 1, n);
    else return m + SumMN(m + 1, n);
}
Console.Write(SumMN(m, n));