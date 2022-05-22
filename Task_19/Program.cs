// Напишите программу ,которая принимает на вход 
//пятизначное число и проверяет ,является ли оно палиндромом.
// 14212 -> нет , 23432 -> да , 12821 -> да .

//   Вариант №1.

// Console.Write(" Введите пятизначное число -> ");
// string num = (Console.ReadLine());
// if (num.Length != 5)
// {
//     Console.Write($" Ваше число : {num} - не пятизначное. ");
//     return;
// }

// if (num[0] == num[4] || num[1] == num[3])
// {
//     Console.Write($" Ваше число : {num} -  Палиндром. ");
// }
// else Console.Write($" Ваше число : {num} - Не палиндром. ");

// Вариант №2.

Console.Write(" Введите пятизначное число -> ");
var num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);
if (numText.Length != 5)
{
    Console.Write($" Ваше число : {num} - не пятизначное. ");
    return;
}

if (numText[0] == numText[4] || numText[1] == numText[3])
{
    Console.Write($" Ваше число : {num} -  Палиндром. ");
}
else Console.Write($" Ваше число : {num} - Не палиндром. ");
