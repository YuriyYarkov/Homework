//Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.

using System;

class Program
{
    static void Main()
    {
        double[] array1 = { 2.9, 3.3, 6.9, 1.9, 8.6 };

        double max = MaxDigit(array1);
        double min = MinDigit(array1);

        double res = max - min;
        Console.WriteLine("Результат: " + res);
    }

    static double MaxDigit(double[] array)
    {
        double max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }

    static double MinDigit(double[] array)
    {
        double min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        return min;
    }
}



