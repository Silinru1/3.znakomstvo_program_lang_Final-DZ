// Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N. Использовать
// рекурсию, не использовать циклы.

// M = 1; N = 5 => "1, 2, 3, 4, 5"
// M = 4; N = 8 => "4, 5, 6, 7, 8"

void Main()
{
    int m = 4;
    int n = 8;
    Recursion(m, n);

    void Recursion(int m, int n)
    {
        if (m > n) return;
        else if (m == n)
        {
            Console.Write(m);
            return;
        }
        Console.Write(m + ", ");
        Recursion(m + 1, n);
    }
}
Main();
