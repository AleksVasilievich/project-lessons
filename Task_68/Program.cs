// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

//           {n + 1, если m = 0;
// A(m, n) = {A(m - 1, 1), если m > 0, n = 0;
//           {A(m - 1, A(m, n - 1)), если m > 0, n > 0.


Console.Write("Enter a non-negative number m -> ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter a non-negative number n -> ");
int n = int.Parse(Console.ReadLine());

AckermanMN(m, n);

int AckermanMN(int m, int n)
{
    if((m < 0) || (n < 0)) return -1;
    if(m == 0)
    {
        return n + 1;
    }
    if((m > 0) && (n == 0))
    {
        return AckermanMN(m - 1, 1);
    }
    else return AckermanMN(m -1, AckermanMN(m, n - 1));
}
Console.Write(AckermanMN(m, n));