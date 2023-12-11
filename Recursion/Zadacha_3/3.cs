// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] array = { 2, 6, 12, 4, 67, 33, 17, 88, 11, 4 };

Console.WriteLine("Исходный массив:");
PrintArray(array, 0);

Console.WriteLine("\nПеревернутый массив:");
PrintArrayReverse(array, array.Length - 1);

void PrintArray(int[] array, int i)
{
    if (i < array.Length)
    {
        Console.Write($"{array[i]} ");
        PrintArray(array, i+1);
    }
}

void PrintArrayReverse(int[] array, int i)
{
    if (i >= 0)
    {
        Console.Write($"{array[i]} ");
        PrintArrayReverse(array, i-1);
    }
}