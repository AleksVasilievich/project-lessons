// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

int m = 7;
int n = 8;
int[,] array = new int[m, n];
void GetArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(-10,10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]}   ");
        }
        Console.WriteLine();
    }
}
void EnumArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (int g = 0; g < array.GetLength(1) - 1; g++)
            {
                if (array[m, g] < array[m, g + 1])
                {
                    int time = array[m, g];
                    array[m, g] = array[m, g + 1];
                    array[m, g + 1] = time;
                }
            }
        }
    }
}
GetArray(array);
PrintArray(array);
Console.WriteLine();
EnumArray(array);
PrintArray(array);
