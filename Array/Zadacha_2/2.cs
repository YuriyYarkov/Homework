//Задайте массив на 10 целых чисел. 
//Напишите программу, которая определяет количество чётных чисел в массиве.

// int[] array = { 5, 7, 12, 66, 89, 4, 17, 23, 99, 40 };
// int count = 0;
// for (int i = 0; i < array.Length; i++)
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
// Console.WriteLine(count);

void EvenDigit(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }

    Console.WriteLine(count);
}

int[] array1 = { 10, 14, 12, 66, 89, 4, 17, 23, 99, 40 };

EvenDigit(array1);