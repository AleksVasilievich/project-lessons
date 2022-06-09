// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.
// Задача 58*: Задайте две матрицы. Напишите программу, которая будет
// *находить произведение двух матриц.

int m = 4;
int n = 4;
int[,] array = new int[m,n];

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]}  ");
        }
        Console.WriteLine();
    }
}


int SumLineArray(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int minNamber = 0;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (m == 0)
            {
                sum += array[m, n];
                minNamber += array[m, n];
            }
            else sum += array[m,n];
        }
        if(sum < minSum)
        {
            minSum = sum;
            minNamber = m;
        }
        sum = 0;
    }
    return minNamber;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("Строку с наименьшей суммой элементов -> " + SumLineArray(array));