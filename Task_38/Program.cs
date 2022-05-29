// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.      [3 7 22 2 78] -> 76

double[] array = { 3.3, -2, 59.7, 12, 34, -24.5, 1, 0, 47.1, 7 };
double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}
Console.WriteLine($"Разница между минимальным и максимальным элементами = {max - min}");

