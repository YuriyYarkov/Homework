// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;

class Program
{
    static void Main()
    {
        int[,] Array2d = {
            {2, 1, 6},
            {8, 7, 4},
            {2, 9, 9}
        };

        Console.Write("Введите номер строки: ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int col = Convert.ToInt32(Console.ReadLine());

        bool found = GetElValue(Array2d, row, col, out int result);

        if (found)
        {
            Console.WriteLine($"Значение элемента в позиции ({row}, {col}): {result}");
        }
        else
        {
            Console.WriteLine("Такого элемента нет");
        }
    }

    
    static bool GetElValue(int[,] array, int row, int col, out int result)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        if (row >= 0 && row < rows && col >= 0 && col < cols)
        {
            result = array[row, col];
            return true;
        }
        else
        {
            result = 0; 
            return false;
        }
    }
}
