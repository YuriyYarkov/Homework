//Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива

using System;

class Program
{
    static void Main()
    {
        int[,] Array2d = {
            {2, 3, 1},
            {4, 5, 6},
            {1, 2, 3}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(Array2d);

        SwapFirstAndLastRows(Array2d);

        Console.WriteLine("\nМассив после замены:");
        PrintArray(Array2d);
    }

    static void SwapFirstAndLastRows(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        if (rows >= 2)
        {
            for (int i = 0; i < cols; i++)
            {
                int temp = array[0, i];
                array[0, i] = array[rows - 1, i];
                array[rows - 1, i] = temp;
            }
        }
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
