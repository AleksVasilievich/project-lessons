// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.WriteLine("Введите позицию строки m ->  ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию столбца n ->  ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

void NumArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((m == i && n == j)) Console.Write(array[i, j]);
        }
        // if(m > array.GetLength(0) || n >array.GetLength(1)) Console.WriteLine("Такого числа в массиве нет");
    }
}

if(m > array.GetLength(0) || n >array.GetLength(1)) Console.WriteLine("Такого числа в массиве нет");
NumArray(array);



