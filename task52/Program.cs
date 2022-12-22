// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetColumnAverage(int[,] array3)
{
    double sum = 0;
    for (int i = 0; i < array3.GetLength(1); i++)
    {
        for (int j = 0; j < array3.GetLength(0); j++)
        {

            sum = sum + array3[j, i];

        }
        double columnAverage = sum / array3.GetLength(0);
        Console.Write($"{columnAverage} ");
        sum = 0;
    }
}

Console.Write("Введите количество строк массива m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива n = ");
int n = int.Parse(Console.ReadLine());
int[,] arr = GetArray(m, n, 0, 10);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца:  ");
GetColumnAverage(arr);
