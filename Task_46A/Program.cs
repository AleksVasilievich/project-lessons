// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
// 12 мин

int[,] arry = new int[m,n];
for (int i = 0; i < arry.GetLength; i++)
{
    for (int j = 0; j < .length; j++)
    {
        
    }
}
// -------------------------------------------------------------------------
// int[,] GetArray(int a, int b)
// {
//     int[,] array = new int[a, b];
//     Random rndNum = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rndNum.Next(10);
//         }
//     }
//     return array;
// }

// void PrintArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] arr = GetArray(5, 7);
// PrintArray(arr);


// От Роман Горкавенко всем 09:08 PM
// int[,] GetArray(int a, int b)
// {
//     int[,] array = new int[a,b];
//     Random rndNum = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] arr = GetArray(3,4);
// PrintArray(arr);

// ------------------------------------------------------
// Сергей, исходя из того, что y = y, сначала делаем уравнение:
// k1 *x + b1 = k2 * x + b2. потом решаем его, перенеся все буквы 
//на одну сторону уравнения, а числа - в другую.  результат решения:
// x = (b2 - b1) / (k2 - k1). это и загоняем в код

----------------------------------------------------------
// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
