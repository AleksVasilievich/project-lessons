// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =
// 9 -> (-0,5; 5,5)

Console.Write("Введите число - b1 = ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите число - k1 = ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите число - b2 = ");
int b2 = int.Parse(Console.ReadLine());
Console.Write("Введите число - k2 = ");
int k2 = int.Parse(Console.ReadLine());

if (k1 == k2)
{
    Console.Write("Прямые паралельны");
    return;
}
string General(int k1, int b1, int k2, int b2)
{
    string result = string.Empty;   
    int x = 0;
    int y = 0;                              // Так как точка общая ->
    x = (b2 - b1) / (k1 - k2);              // k1 * x + b1 = k2 * x + b2
    y = (k1 * (b2 - b1) / (k1 - k2)) + b2;
    result = $"({x},{y})";
    return result;
}
Console.Write(General(k1, b1, k2, b2));