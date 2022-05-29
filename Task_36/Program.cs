// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.    
//  [3, 7, 23, 12] -> 19        [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива -> ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int sum = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}
for (int j = 0; j < size; j++)
{
    if (j % 2 != 0) sum = sum + array[j];
}

Console.WriteLine($" Сумма элементов стоящих на нечётных позициях = {sum}");
