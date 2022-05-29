// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число -> ");
int num = int.Parse(Console.ReadLine());
int lengthNum = Convert.ToString(num).Length;
int sum = 0;
int less1Num = 0;
int i = 0;
while (i < lengthNum)
{
    less1Num = num - num % 10;                                   
    sum = sum + (num - less1Num);
    num = num / 10;
    i++;
}
Console.Write($"Сумма цифр заданного числа -> {sum} ");

