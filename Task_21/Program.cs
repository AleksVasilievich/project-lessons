// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве. А(3,6);В(2,1)-> 5,09
/*
Console.WriteLine("Введите координаты А : ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты В : ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

double sum = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
double result = Math.Sqrt(sum);

Console.WriteLine($"{result:F2}");
*/


//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве. А(3,6,8);В(2,1,-7)-> 15,84

Console.WriteLine("Введите координаты А : ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты В : ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double sum = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2);
double result = Math.Sqrt(sum);

Console.WriteLine($"{result:F2}");
