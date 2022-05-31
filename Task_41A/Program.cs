// Задача 41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223->3

Console.WriteLine("Введите числа  -> ");
var numM = Console.ReadLine();
//int[] arry = {};
for (int i = 0; i < numM.Length; i++)
{
   numM[i] = i * i; 
}
Console.WriteLine(numM[i]);
// int positive = 0;
// for (int i = 0; i < numM.Length; i++)
// {
//    positive = positive + i; 
// }
// Console.WriteLine(positive);