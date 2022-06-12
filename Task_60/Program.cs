// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

void TripleArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
            
                
                //if(i == 0 && j == 0 && i == 0) return;
                if (i != j && j != c && i != c) array[i, j, c] = new Random().Next(9, 100);
                 else array[i, j, c] = new Random().Next(9, 100);
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("   ");
            for (int c = 0; c < array.GetLength(2); c++)
            {
                Console.Write($"{array[i, j, c]}   ");
            }
        }
    }
    Console.WriteLine();
}

int[,,] array = new int[3, 3, 3];
TripleArray(array);
PrintArray(array);