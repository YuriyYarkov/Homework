//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumRowArray(int[,] array)
{
    int[] sumArr = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArr[i] += array[i, j];
        }

    }
    int minSum = sumArr[0];
    int minRow = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (sumArr[i] < minSum)
        {
            minSum = sumArr[i];
            minRow = i + 1;
        }
    }
    return minRow;
}
int[,] array2d = {
    {5, 8, 5, 4},
    {4, 5, 6, 1},
    {3, 7, 3, 5}
};
PrintArray(array2d);
int row = SumRowArray(array2d);
Console.WriteLine($"Наименьшая сумма в {row} строке.");