// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 => A(m,n) = 29

void Main()
{
    result();

    int Acc(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (m > 0 && n == 0) return Acc(m - 1, 1);
        else return Acc(m - 1, Acc(m, n - 1));
    }

    void result()
    {
        Console.WriteLine("Input numbers for M and N: ");
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Accirman function equal to: " + Acc(m, n));
    }
}
Main();
