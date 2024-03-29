﻿// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите длинну столбцов -> ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите длинну строк -> ");
int n = int.Parse(Console.ReadLine());
double[,] GetArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(-100, 100) * 0.1;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{"{0:F1}"}  ", array[i, j]);
        }
        Console.WriteLine();
    }
}
Console.Write($"{"m = " + m}  , {"n =  " + n}  ");
Console.WriteLine();
double[,] arr = GetArray(m, n);
PrintArray(arr);
