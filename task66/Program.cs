// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumOfElementsBetweenMAndN(int m, int n)
{
    if (m < n)
    {
        if (m != n) m = n + GetSumOfElementsBetweenMAndN(m, n - 1); return m;
    }
    else
    {
        if (m != n) m = n + GetSumOfElementsBetweenMAndN(m, n + 1); return m;
    }
    ;
}

Console.WriteLine(GetSumOfElementsBetweenMAndN(4, 8));

