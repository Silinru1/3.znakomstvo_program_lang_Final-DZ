// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;

class Main
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите два неотрицательных числа");
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Функция Аккермана равна " + Acc(m, n));
    }

    static int Acc(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Acc(m - 1, 1);
        }
        else
        {
            return Acc(m - 1, Acc(m, n - 1));
        }
    }
}
