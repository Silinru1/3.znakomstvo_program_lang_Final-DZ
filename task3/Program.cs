// Задайте произвольный массив. Выведете его элементы,
// начиная с конца. Использовать рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34, 10, 0, 5, 2, 1

void Main()
{
    int[] array = { 1, 2, 5, 0, 10, 34 };
    reverseArray(array);

    void reverseArray(int[] arr)
    {
        int size = arr.Length - 1;
        if (arr.Length == 1)
        {
            Console.Write(arr[0]);
            return;
        }
        Console.Write(arr[size] + ", ");
        reverseArray(arr[..size]);
    }
}
Main();
