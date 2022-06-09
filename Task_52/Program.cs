// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Введите длинну столбцов -> ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите длинну строк -> ");
int n = int.Parse(Console.ReadLine());

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
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}
double ArithmeticMean(int[,] array)
{
    double result = 0;
    // double result = 0;
    for (int n = 0; n < array.GetLength(1); n++)
    {
        int sum = 0;
        // int count = 0;
        double mean = 0;
        for (int m = 0; m < array.GetLength(0); m++)
        {
            sum += array[m, n];
            //count++;
        }
        mean = sum / m;
        Console.Write(mean);//Split().Select.(int.Parse);
        //result = mean;
        //result = result + mean.ToString() + " ";
        //result = ((byte)mean);
         //Console.Write($"{Math.Round((float)sum / array.GetLength(0), 1)};  ");
    }
    return result;
}
//int m = 5;
//int n = 5;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(ArithmeticMean(array));


// Console.Write("Введите длинну столбцов -> ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите длинну строк -> ");
// int n = int.Parse(Console.ReadLine());

// void FillArray(int[,] array)
// {
//     for (int m = 0; m < array.GetLength(0); m++)
//     {
//         for (int n = 0; n < array.GetLength(1); n++)
//         {
//             array[m, n] = new Random().Next(10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int m = 0; m < array.GetLength(0); m++)
//     {
//         for (int n = 0; n < array.GetLength(1); n++)
//         {
//             Console.Write($"{array[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// string ArithmeticMean(int[,] array)
// {
//     string result = string.Empty;
//     //int mean = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         //int result = 0;
//         int sum = 0;
//         int count = 0;
//         double mean = 0;
//         //double[] arr = new double[n];
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             sum += array[i, j];
//             count++;
//         }
//         //int a = 0;
//         mean = sum / count;//count;     // mean = sum / count;
//         result += mean.ToString() + " ";
//         // return  result;// mean++;
//     }
//     return result;
// }
// int[,] array = new int[m, n];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine(ArithmeticMean(array));