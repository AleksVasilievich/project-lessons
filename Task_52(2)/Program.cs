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
string NumArray(int[,] array)
{
    string sum = string.Empty;
    Console.Write("Введите число");
    int num = int.Parse(Console.ReadLine());

    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (num = array[m,n]) sum += $"({m},{n})";  //Console.Write(array[i, j]);
        }
    }
    if (sum == string.Empty) sum = "Такова числа в массиве нет";
    return sum;
}
Console.Write(NumArray(array));