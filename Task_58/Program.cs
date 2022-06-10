// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.



void GetArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1,10);
        }
    }

}

void GetArray1(int[,] array1)
{
    for (int m = 0; m < array1.GetLength(0); m++)
    {
        for (int n = 0; n < array1.GetLength(1); n++)
        {
            array1[m, n] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                Console.Write($"{array[m, n]}  ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();

}

void PrintArray1(int[,] array1)
{
       for (int m = 0; m < array1.GetLength(0); m++)
    {
        for (int n = 0; n < array1.GetLength(1); n++)
        {
            Console.Write($"{array1[m, n]}  ");
        }
        Console.WriteLine();
    }

}

void MultArray(int[,]array,int[,] array1, int[,] multArray)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
           multArray[m,n] = array[m,n] * array1[m,n]; 
        }
    }
}

int[,] array = new int[3, 3];
int[,] array1 = new int[3, 3];
int[,] multArray = new int[3,3];

GetArray(array);
GetArray1(array1);
PrintArray(array);
PrintArray1(array1);
Console.WriteLine();
MultArray(array,array1,multArray);
PrintArray(multArray);