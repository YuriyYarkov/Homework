//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int m = 2;
int n = 4;

int result = AkermanFunc(m, n);
Console.WriteLine($"Значение функции Аккермана для m = {m}, n = {n}: {result}");

int AkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AkermanFunc(m - 1, 1);
    }
    else
    {
        return AkermanFunc(m - 1, AkermanFunc(m, n - 1));
    }
}

